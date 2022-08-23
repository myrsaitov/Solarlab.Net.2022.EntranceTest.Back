using Moq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using AutoFixture.Xunit2;
using System.Collections.Generic;
using Sev1.Congratulations.AppServices.Services.Congratulation.Exceptions;

namespace Sev1.Congratulations.Tests.Congratulation
{
    public partial class CongratulationServiceV1Test
    {
        /// <summary>
        /// Проверка получения объявления по Id
        /// </summary>
        /// <param name="id">Идентификатор объявления</param>
        /// <param name="cancellationToken">Маркёр отмены</param>
        /// <param name="userId">Идентификатор пользователя</param>
        /// <param name="advertisementTitle">Заголовок объявления</param>
        /// <param name="advertisementBody">Тело объявления</param>
        /// <param name="tagBodies">Таги</param>
        /// <param name="userId">Идентификатор пользователя, который создал объявление</param>
        /// <param name="categoryId">Идентификатор категории</param>
        /// <returns></returns>
        [Theory]
        [AutoData]
        public async Task GetById_Returns_Response_Success(
            int? id, 
            CancellationToken cancellationToken, 
            string advertisementTitle,
            string advertisementBody,
            string[] tagBodies,
            string userId,
            int? categoryId)
        {
            // Arrange

            // Объект, который возвращается из базы
            var congratulation = new Domain.Congratulation()
            {
                Title = advertisementTitle,
                Body = advertisementBody,
                OwnerId = userId,
                Category = new Domain.Category()
                {
                    Id = categoryId
                },
                Tags = new List<Domain.Tag>()
            };

            // Заполняем таги
            int? tagId = 1;
            foreach (string body in tagBodies)
            {
                var tag = new Domain.Tag()
                {
                    Id = tagId++,
                    Body = body
                };
                congratulation.Tags.Add(tag);
            }

            // "Достаем" из базы
            _advertisementRepositoryMock
                .Setup(_ => _.FindByIdWithCategoriesAndTagsAndUserFiles(
                    It.IsAny<int?>(), // проверяет, что параметр имеет указанный тип <>
                    It.IsAny<CancellationToken>())) // проверяет, что параметр имеет указанный тип <>
                .ReturnsAsync(congratulation) // в результате выполнения возвращает объект
                .Callback(( // Используем передаваемые в мок аргументы для имитации логики
                    int? _advertisementId, 
                    CancellationToken ct) => congratulation.Id = _advertisementId)
                .Verifiable(); // Verify all verifiable expectations on all mocks created through the repository

            // Act
            var response = await _advertisementServiceV1.GetById(
                id, 
                cancellationToken);

            // Assert
            _advertisementRepositoryMock.Verify(); // Вызывался ли данный мок?
            Assert.NotNull(response);
            Assert.NotEqual(default, response.Id);
        }

        /// <summary>
        /// Проверка исключения, если в базе нет объявления с таким Id
        /// </summary>
        /// <param name="id">Идентификатор объявления</param>
        /// <param name="cancellationToken">Маркёр отмены</param>
        /// <returns></returns>
        [Theory]
        [AutoData]
        public async Task GetById_Throws_Exception_When_Congratulation_Is_Null(
            int? id,
            CancellationToken cancellationToken)
        {
            // Arrange

            // Объект, который возвращается из базы
            Domain.Congratulation congratulation = null;

            // "Достаем" из базы
            _advertisementRepositoryMock
                .Setup(_ => _.FindByIdWithCategoriesAndTagsAndUserFiles(
                    It.IsAny<int?>(), // проверяет, что параметр имеет указанный тип <>
                    It.IsAny<CancellationToken>())) // проверяет, что параметр имеет указанный тип <>
                .ReturnsAsync(congratulation); // в результате выполнения возвращает объект
 
            // Act
            await Assert.ThrowsAsync<CongratulationNotFoundException>(
                async () => await _advertisementServiceV1.GetById(
                    id,
                    cancellationToken));
        }

        /// <summary>
        /// Проверка исключения, если аргумент не проходит валидацию
        /// </summary>
        /// <param name="id">Идентификатор объявления</param>
        /// <param name="cancellationToken">Маркёр отмены</param>
        /// <returns></returns>
        [Theory]
        [InlineAutoData(null,null)]
        public async Task GetById_Throws_Exception_When_Request_Is_Null(
            int? id, 
            CancellationToken cancellationToken)
        {
            // Act
            await Assert.ThrowsAsync<CongratulationIdNotValidException>(
                async () => await _advertisementServiceV1.GetById(
                    id, 
                    cancellationToken));
        }
    }
}