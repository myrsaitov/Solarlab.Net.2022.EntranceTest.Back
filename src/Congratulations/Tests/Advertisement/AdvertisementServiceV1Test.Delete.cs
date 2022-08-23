using Moq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using AutoFixture.Xunit2;
using Sev1.Congratulations.Domain.Base.Exceptions;
using Sev1.Congratulations.AppServices.Services.Congratulation.Exceptions;

namespace Sev1.Congratulations.Tests.Congratulation
{
    public partial class CongratulationServiceV1Test
    {
        /// <summary>
        /// Проверка удачного удаления объявления пользователем-owner
        /// </summary>
        /// <param name="id">Идентификатор объявления</param>
        /// <param name="cancellationToken">Маркёр отмены</param>
        /// <returns></returns>
        [Theory]
        [AutoData]
        public async Task Delete_ByOwner_Returns_Response_Success(
            int? id, 
            CancellationToken cancellationToken)
        {
            // Arrange

            // "Проверка" роли администратора (false)
            _userProviderMock
                .Setup(_ => _.IsInRole(It.Is<string>(s => s.Contains("Administrator"))))
                .Returns(false) // возвращает в результате выполнения
                .Verifiable(); // Verify all verifiable expectations on all mocks created through the repository

            // "Проверка" роли модератора (false)
            _userProviderMock
                .Setup(_ => _.IsInRole(It.Is<string>(s => s.Contains("Moderator"))))
                .Returns(false) // возвращает в результате выполнения
                .Verifiable(); // Verify all verifiable expectations on all mocks created through the repository

            // Возвращаем польователя, который "удаляет" это объявление
            _userProviderMock
                .Setup(_ => _.GetUserId())
                .Returns("24cb4b25-c819-45ab-8755-d95120fbb868") // возвращает в результате выполнения
                .Verifiable(); // Verify all verifiable expectations on all mocks created through the repository

            // "Достаем" объявление из базы
            var congratulation = new Domain.Congratulation()
            {
                OwnerId = "24cb4b25-c819-45ab-8755-d95120fbb868"
            };
            _advertisementRepositoryMock
                .Setup(_ => _.FindByIdWithTagsInclude(
                    It.IsAny<int?>(), // проверяет, что параметр имеет указанный тип <>
                    It.IsAny<CancellationToken>())) // проверяет, что параметр имеет указанный тип <>
                .ReturnsAsync(congratulation) // в результате выполнения возвращает объект
                .Callback(( // Используем передаваемые в мок аргументы для имитации логики
                    int? _advertisementId,
                    CancellationToken ct) => congratulation.Id = _advertisementId)
                .Verifiable(); // Verify all verifiable expectations on all mocks created through the repository

            // "Сохраняем" объявление в базу
            _advertisementRepositoryMock
                .Setup(_ => _.Save(
                    It.IsAny<Domain.Congratulation>(), // проверяет, что параметр имеет указанный тип <>
                    It.IsAny<CancellationToken>())) // проверяет, что параметр имеет указанный тип <>
                .Callback(( // Используем передаваемые в мок аргументы для имитации логики
                    Domain.Congratulation congratulation,
                    CancellationToken ct) => congratulation.Id = id);

            // Act
            await _advertisementServiceV1.Delete(
                id, 
                cancellationToken);

            // Assert
            _userProviderMock.Verify(); // Вызывался ли данный мок?
            _advertisementRepositoryMock.Verify(); // Вызывался ли данный мок?
        }

        /// <summary>
        /// Проверка удачного удаления объявления модератором
        /// </summary>
        /// <param name="id">Идентификатор объявления</param>
        /// <param name="cancellationToken">Маркёр отмены</param>
        /// <returns></returns>
        [Theory]
        [AutoData]
        public async Task Delete_ByModerator_Returns_Response_Success(
            int? id,
            CancellationToken cancellationToken)
        {
            // Arrange

            // "Проверка" роли администратора (false)
            _userProviderMock
                .Setup(_ => _.IsInRole(It.Is<string>(s => s.Contains("Administrator"))))
                .Returns(false) // возвращает в результате выполнения
                .Verifiable(); // Verify all verifiable expectations on all mocks created through the repository

            // "Проверка" роли модератора (true)
            _userProviderMock
                .Setup(_ => _.IsInRole(It.Is<string>(s => s.Contains("Moderator"))))
                .Returns(true) // возвращает в результате выполнения
                .Verifiable(); // Verify all verifiable expectations on all mocks created through the repository

            // Возвращаем польователя, который "удаляет" это объявление
            _userProviderMock
                .Setup(_ => _.GetUserId())
                .Returns("dd1de902-f2e1-4248-8481-b3b0e3d76837") // возвращает в результате выполнения
                .Verifiable(); // Verify all verifiable expectations on all mocks created through the repository

            // "Достаем" объявление из базы
            var congratulation = new Domain.Congratulation()
            {
                OwnerId = "24cb4b25-c819-45ab-8755-d95120fbb868"
            };
            _advertisementRepositoryMock
                .Setup(_ => _.FindByIdWithTagsInclude(
                    It.IsAny<int?>(), // проверяет, что параметр имеет указанный тип <>
                    It.IsAny<CancellationToken>())) // проверяет, что параметр имеет указанный тип <>
                .ReturnsAsync(congratulation) // в результате выполнения возвращает объект
                .Callback(( // Используем передаваемые в мок аргументы для имитации логики
                    int? _advertisementId,
                    CancellationToken ct) => congratulation.Id = _advertisementId)
                .Verifiable(); // Verify all verifiable expectations on all mocks created through the repository

            // "Сохраняем" объявление в базу
            _advertisementRepositoryMock
                .Setup(_ => _.Save(
                    It.IsAny<Domain.Congratulation>(), // проверяет, что параметр имеет указанный тип <>
                    It.IsAny<CancellationToken>())) // проверяет, что параметр имеет указанный тип <>
                .Callback(( // Используем передаваемые в мок аргументы для имитации логики
                    Domain.Congratulation congratulation,
                    CancellationToken ct) => congratulation.Id = id);

            // Act
            await _advertisementServiceV1.Delete(
                id,
                cancellationToken);

            // Assert
            _userProviderMock.Verify(); // Вызывался ли данный мок?
            _advertisementRepositoryMock.Verify(); // Вызывался ли данный мок?
        }

        /// <summary>
        /// Проверка удачного удаления объявления админом
        /// </summary>
        /// <param name="id">Идентификатор объявления</param>
        /// <param name="cancellationToken">Маркёр отмены</param>
        /// <returns></returns>
        [Theory]
        [AutoData]
        public async Task Delete_ByAdministrator_Returns_Response_Success(
            int? id,
            CancellationToken cancellationToken)
        {
            // Arrange

            // "Проверка" роли администратора (true)
            _userProviderMock
                .Setup(_ => _.IsInRole(It.Is<string>(s => s.Contains("Administrator"))))
                .Returns(true) // возвращает в результате выполнения
                .Verifiable(); // Verify all verifiable expectations on all mocks created through the repository

            // "Проверка" роли модератора (false)
            _userProviderMock
                .Setup(_ => _.IsInRole(It.Is<string>(s => s.Contains("Moderator"))))
                .Returns(false) // возвращает в результате выполнения
                .Verifiable(); // Verify all verifiable expectations on all mocks created through the repository

            // Возвращаем польователя, который "удаляет" это объявление
            _userProviderMock
                .Setup(_ => _.GetUserId())
                .Returns("dd1de902-f2e1-4248-8481-b3b0e3d76837") // возвращает в результате выполнения
                .Verifiable(); // Verify all verifiable expectations on all mocks created through the repository

            // "Достаем" объявление из базы
            var congratulation = new Domain.Congratulation()
            {
                OwnerId = "24cb4b25-c819-45ab-8755-d95120fbb868"
            };
            _advertisementRepositoryMock
                .Setup(_ => _.FindByIdWithTagsInclude(
                    It.IsAny<int?>(), // проверяет, что параметр имеет указанный тип <>
                    It.IsAny<CancellationToken>())) // проверяет, что параметр имеет указанный тип <>
                .ReturnsAsync(congratulation) // в результате выполнения возвращает объект
                .Callback(( // Используем передаваемые в мок аргументы для имитации логики
                    int? _advertisementId,
                    CancellationToken ct) => congratulation.Id = id)
                .Verifiable(); // Verify all verifiable expectations on all mocks created through the repository

            // "Сохраняем" объявление в базу
            _advertisementRepositoryMock
                .Setup(_ => _.Save(
                    It.IsAny<Domain.Congratulation>(), // проверяет, что параметр имеет указанный тип <>
                    It.IsAny<CancellationToken>())) // проверяет, что параметр имеет указанный тип <>
                .Callback(( // Используем передаваемые в мок аргументы для имитации логики
                    Domain.Congratulation congratulation,
                    CancellationToken ct) => congratulation.Id = id);

            // Act
            await _advertisementServiceV1.Delete(
                id,
                cancellationToken);

            // Assert
            _userProviderMock.Verify(); // Вызывался ли данный мок?
            _advertisementRepositoryMock.Verify(); // Вызывался ли данный мок?
        }

        /// <summary>
        /// Проверка исключения, если пользователь 
        /// не имеет права удалить объявление
        /// </summary>
        /// <param name="id">Идентификатор объявления</param>
        /// <param name="cancellationToken">Маркёр отмены</param>
        /// <returns></returns>
        [Theory]
        [AutoData]
        public async Task Delete_Throws_Exception_When_No_Rights(
            int? id,
            CancellationToken cancellationToken)
        {
            // Arrange

            // Arrange

            // "Проверка" роли администратора (false)
            _userProviderMock
                .Setup(_ => _.IsInRole(It.Is<string>(s => s.Contains("Administrator"))))
                .Returns(false) // возвращает в результате выполнения
                .Verifiable(); // Verify all verifiable expectations on all mocks created through the repository

            // "Проверка" роли модератора (false)
            _userProviderMock
                .Setup(_ => _.IsInRole(It.Is<string>(s => s.Contains("Moderator"))))
                .Returns(false) // возвращает в результате выполнения
                .Verifiable(); // Verify all verifiable expectations on all mocks created through the repository

            // Возвращаем польователя, который "удаляет" это объявление
            _userProviderMock
                .Setup(_ => _.GetUserId())
                .Returns("dd1de902-f2e1-4248-8481-b3b0e3d76837") // возвращает в результате выполнения
                .Verifiable(); // Verify all verifiable expectations on all mocks created through the repository
            
            // "Возвращаем" объявление по Id
            var congratulation = new Domain.Congratulation()
            {
                OwnerId = "24cb4b25-c819-45ab-8755-d95120fbb868"
            };
            _advertisementRepositoryMock
                .Setup(_ => _.FindByIdWithTagsInclude(
                    It.IsAny<int?>(), // проверяет, что параметр имеет указанный тип <>
                    It.IsAny<CancellationToken>())) // проверяет, что параметр имеет указанный тип <>
                .ReturnsAsync(congratulation) // в результате выполнения возвращает объект
                .Callback(( // Используем передаваемые в мок аргументы для имитации логики
                    int? _advertisementId,
                    CancellationToken ct) => congratulation.Id = _advertisementId);

            // "Сохраняем" объявление
            _advertisementRepositoryMock
                .Setup(_ => _.Save(
                    It.IsAny<Domain.Congratulation>(), // проверяет, что параметр имеет указанный тип <>
                    It.IsAny<CancellationToken>())) // проверяет, что параметр имеет указанный тип <>
                .Callback(( // Используем передаваемые в мок аргументы для имитации логики
                    Domain.Congratulation congratulation,
                    CancellationToken ct) => congratulation.Id = id);

            // Act
            await Assert.ThrowsAsync<NoRightsException>(
                async () => await _advertisementServiceV1.Delete(
                    id, 
                    cancellationToken));
        }

        /// <summary>
        /// Проверка исключения, если в базе нет объявления с таким Id
        /// </summary>
        /// <param name="id">Идентификатор объявления</param>
        /// <param name="cancellationToken">Маркёр отмены</param>
        /// <returns></returns>
        [Theory]
        [AutoData]
        public async Task Delete_Throws_Exception_When_Congratulation_Is_Null(
            int? id,
            CancellationToken cancellationToken)
        {
            // Arrange

            // "Достаем" объявление из базы
            Domain.Congratulation congratulation = null;
            _advertisementRepositoryMock
                .Setup(_ => _.FindByIdWithTagsInclude(
                    It.IsAny<int?>(), // проверяет, что параметр имеет указанный тип <>
                    It.IsAny<CancellationToken>())) // проверяет, что параметр имеет указанный тип <>
                .ReturnsAsync(congratulation); // в результате выполнения возвращает объект

            // Act
            await Assert.ThrowsAsync<CongratulationNotFoundException>(
                async () => await _advertisementServiceV1.Delete(
                    id, 
                    cancellationToken));
        }

        /// <summary>
        /// Проверка исключения, если не прошли валидацию Id
        /// </summary>
        /// <param name="id">Идентификатор объявления</param>
        /// <param name="cancellationToken">Маркёр отмены</param>
        /// <returns></returns>
        [Theory]
        [InlineAutoData(null, null)]
        public async Task Delete_Throws_Exception_When_Id_Is_Not_Valid(
            int? id,
            CancellationToken cancellationToken)
        {
            // Act
            await Assert.ThrowsAsync<CongratulationIdNotValidException>(
                async () => await _advertisementServiceV1.Delete(
                    id,
                    cancellationToken));
        }
    }
}