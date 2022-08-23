using System.Threading;
using System.Threading.Tasks;
using System;
using Sev1.Congratulations.AppServices.Services.Congratulation.Interfaces;
using System.Collections.Generic;
using Sev1.Congratulations.Contracts.Contracts.Tag.Requests;

namespace Sev1.Congratulations.AppServices.Services.Congratulation.Implementations
{
    public sealed partial class CongratulationServiceV1 : ICongratulationService
    {
        /// <summary>
        /// Добавить таги к объявлению
        /// </summary>
        /// <param name="congratulation">Объект объявления</param>
        /// <param name="TagBodies">Массив тагов</param>
        /// <param name="cancellationToken">Маркёр отмены</param>
        /// <returns></returns>
        public async Task AddTags(
            Domain.Congratulation congratulation,
            string[] TagBodies,
            CancellationToken cancellationToken)
        {
            // Добавляем таги
            if (TagBodies is not null)
            {
                congratulation.Tags = new List<Domain.Tag>();
                foreach (string body in TagBodies)
                {
                    if (!string.IsNullOrWhiteSpace(body))
                    {
                        var tag = await _tagRepository.FindWhere(
                            a => a.Body == body,
                            cancellationToken);

                        if (tag == null)
                        {
                            var tagRequest = new TagCreateRequest()
                            {
                                Body = body
                            };

                            tag = _mapper.Map<Domain.Tag>(tagRequest);
                            tag.CreatedAt = DateTime.UtcNow;

                            await _tagRepository.Save(
                                tag,
                                cancellationToken);
                        }
                        else
                        {
                            await _tagRepository.Save(tag, cancellationToken);
                        }

                        congratulation.Tags.Add(tag);
                    }
                }
            }
        }
    }
}