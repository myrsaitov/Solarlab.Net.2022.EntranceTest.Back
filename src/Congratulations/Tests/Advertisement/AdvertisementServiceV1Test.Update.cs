using Moq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using AutoFixture.Xunit2;
using System.Linq.Expressions;
using System;
using Sev1.Congratulations.AppServices.Contracts.Congratulation.Requests;
using Sev1.Congratulations.Domain.Base.Exceptions;
using Sev1.Congratulations.AppServices.Services.Congratulation.Exceptions;
using Sev1.Congratulations.AppServices.Services.Category.Exceptions;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace Sev1.Congratulations.Tests.Congratulation
{
    public partial class CongratulationServiceV1Test
    {
        /// <summary>
        /// Проверка удачного обновления объявления
        /// </summary>
        /// <param name="request">DTO-модель</param>
        /// <param name="cancellationToken">Маркёр отмены</param>
        /// <returns></returns>
        [Theory]
        [AutoData]
        public async Task Update_Returns_Response_Success(
            CongratulationUpdateRequest request,
            List<IFormFile> files,
            CancellationToken cancellationToken)
        {
            // Arrange

            // Чтобы пройти валидацию, правим tags
            request.TagBodies = new string[3] { "111", "222", "333" };

            // "Возвращаем" польователя, который "восстанавливает" это объявление
            _userProviderMock
                .Setup(_ => _.GetUserId())
                .Returns("24cb4b25-c819-45ab-8755-d95120fbb868") // возвращает в результате выполнения
                .Verifiable(); // Verify all verifiable expectations on all mocks created through the repository

            // Объект категории, который "возвращается" из базы
            var category = new Domain.Category();
            _categoryRepositoryMock
                .Setup(_ => _.FindById(
                    It.IsAny<int?>(), // проверяет, что параметр имеет указанный тип <>
                    It.IsAny<CancellationToken>())) // проверяет, что параметр имеет указанный тип <>
                .ReturnsAsync(category) // в результате выполнения возвращает объект
                .Callback(( // Используем передаваемые в мок аргументы для имитации логики
                    int? _categoryId,
                    CancellationToken ct) => category.Id = _categoryId)
                .Verifiable(); // Verify all verifiable expectations on all mocks created through the repository

            // Объект объявления, который "возвращается" из базы
            var congratulation = new Domain.Congratulation()
            {
                OwnerId = "24cb4b25-c819-45ab-8755-d95120fbb868"
            };
            _advertisementRepositoryMock
                .Setup(_ => _.FindByIdWithCategoriesAndTagsAndUserFiles(
                    It.IsAny<int?>(), // проверяет, что параметр имеет указанный тип <>
                    It.IsAny<CancellationToken>())) // проверяет, что параметр имеет указанный тип <>
                .ReturnsAsync(congratulation) // в результате выполнения возвращает объект
                .Callback(( // Используем передаваемые в мок аргументы для имитации логики
                    int? _advertisementId,
                    CancellationToken ct) => congratulation.Id = _advertisementId)
                .Verifiable(); // Verify all verifiable expectations on all mocks created through the repository

            // Id тага, который "возвращается" из базы
            int tagId = 1;
            // "Поиск" тага в базе
            _tagRepositoryMock
                .Setup(_ => _.FindWhere(
                    It.IsAny<Expression<Func<Domain.Tag, bool>>>(), // проверяет, что параметр имеет указанный тип <>
                    It.IsAny<CancellationToken>())) // проверяет, что параметр имеет указанный тип <>
                .ReturnsAsync(() => new Domain.Tag()
                {
                    Id = tagId,
                    Body = request.TagBodies[tagId++ - 1]
                }) // в результате выполнения возвращает объект
                .Verifiable(); // Verify all verifiable expectations on all mocks created through the repository

            // "Сохранение" тага в базе
            _tagRepositoryMock
                .Setup(_ => _.Save(
                    It.IsAny<Domain.Tag>(), // проверяет, что параметр имеет указанный тип <>
                    It.IsAny<CancellationToken>())); // проверяет, что параметр имеет указанный тип <>

            // "Сохранение" объявления в базе
            _advertisementRepositoryMock
                .Setup(_ => _.Save(
                    It.IsAny<Domain.Congratulation>(), // проверяет, что параметр имеет указанный тип <>
                    It.IsAny<CancellationToken>())) // проверяет, что параметр имеет указанный тип <>
                .Callback(( // Используем передаваемые в мок аргументы для имитации логики
                    Domain.Congratulation congratulation,
                    CancellationToken ct) => congratulation.Id = 1); // Id "созданного" объявления

            // Act
            await _advertisementServiceV1.Update(
                request,
                files,
                cancellationToken);

            // Assert
            _userProviderMock.Verify(); // Вызывался ли данный мок?
            _advertisementRepositoryMock.Verify(); // Вызывался ли данный мок?
            _categoryRepositoryMock.Verify(); // Вызывался ли данный мок?
            _tagRepositoryMock.Verify(); // Вызывался ли данный мок?
        }

        /// <summary>
        /// Проверяет реакцию на отсутствие аутентификации
        /// </summary>
        /// <param name="request">DTO-модель</param>
        /// <param name="cancellationToken">Маркёр отмены</param>
        /// <returns></returns>
        [Theory]
        [AutoData] //accessToken = null, а остальное автозаполняется
        public async Task Update_Throws_Exception_When_CurrentUserId_Is_Null(
            CongratulationUpdateRequest request,
            List<IFormFile> files,
            CancellationToken cancellationToken)
        {
            {
                // Arrange

                // Чтобы пройти валидацию, правим tags
                request.TagBodies = new string[3] { "111", "222", "333" };

                // Объект категории, который "возвращается" из базы
                var category = new Domain.Category();
                _categoryRepositoryMock
                    .Setup(_ => _.FindById(
                        It.IsAny<int?>(), // проверяет, что параметр имеет указанный тип <>
                        It.IsAny<CancellationToken>())) // проверяет, что параметр имеет указанный тип <>
                    .ReturnsAsync(category) // в результате выполнения возвращает объект
                    .Callback(( // Используем передаваемые в мок аргументы для имитации логики
                        int? _categoryId,
                        CancellationToken ct) => category.Id = _categoryId)
                    .Verifiable(); // Verify all verifiable expectations on all mocks created through the repository

                // Объект объявления, который "возвращается" из базы
                var congratulation = new Domain.Congratulation()
                {
                    OwnerId = "24cb4b25-c819-45ab-8755-d95120fbb868"
                };
                _advertisementRepositoryMock
                    .Setup(_ => _.FindByIdWithCategoriesAndTagsAndUserFiles(
                        It.IsAny<int?>(), // проверяет, что параметр имеет указанный тип <>
                        It.IsAny<CancellationToken>())) // проверяет, что параметр имеет указанный тип <>
                    .ReturnsAsync(congratulation) // в результате выполнения возвращает объект
                    .Callback(( // Используем передаваемые в мок аргументы для имитации логики
                        int? _advertisementId,
                        CancellationToken ct) => congratulation.Id = _advertisementId)
                    .Verifiable(); // Verify all verifiable expectations on all mocks created through the repository

                // "Возвращаем" польователя, который "восстанавливает" это объявление
                _userProviderMock
                    .Setup(_ => _.GetUserId())
                    .Returns(""); // возвращает в результате выполнения
 
                // Act
                await Assert.ThrowsAsync<NoRightsException>(
                    async () => await _advertisementServiceV1.Update(
                        request,
                        files,
                        cancellationToken));
            }
        }

        /// <summary>
        /// Проверяет реакцию на невалидный аргумент
        /// </summary>
        /// <param name="request">DTO-модель</param>
        /// <param name="cancellationToken">Маркёр отмены</param>
        /// <returns></returns>
        [Theory]
        [InlineAutoData(null, null)]
        public async Task Update_Throws_Exception_When_Request_Is_Null(
            CongratulationUpdateRequest request,
            List<IFormFile> files,
            CancellationToken cancellationToken)
        {
            // Act
            await Assert.ThrowsAsync<CongratulationUpdateRequestNotValidException>(
                async () => await _advertisementServiceV1.Update(
                    request,
                    files,
                    cancellationToken));
        }

        /// <summary>
        /// Проверка, когда объявление не найдено в базе
        /// </summary>
        /// <param name="request">DTO-модель</param>
        /// <param name="cancellationToken">Маркёр отмены</param>
        /// <returns></returns>
        [Theory]
        [AutoData]
        public async Task Update_Throws_Exception_When_Congratulation_Is_Null(
            CongratulationUpdateRequest request,
            List<IFormFile> files,
            CancellationToken cancellationToken)
        {
            // Arrange

            // Чтобы пройти валидацию, правим tags
            request.TagBodies = new string[3] { "111", "222", "333" };

            // Чтобы вернуть пустое объявление
            Domain.Congratulation congratulation = null;
            _advertisementRepositoryMock
                .Setup(_ => _.FindById(
                    It.IsAny<int?>(), // проверяет, что параметр имеет указанный тип <>
                    It.IsAny<CancellationToken>())) // проверяет, что параметр имеет указанный тип <>
                .ReturnsAsync(congratulation) // в результате выполнения возвращает объект
                .Verifiable(); // Verify all verifiable expectations on all mocks created through the repository

            // Act
            await Assert.ThrowsAsync<CongratulationNotFoundException>(
                async () => await _advertisementServiceV1.Update(
                    request,
                    files,
                    cancellationToken));
        }


        /// <summary>
        /// Проверяет реакцию на отсутствие категории
        /// </summary>
        /// <param name="request">DTO-модель</param>
        /// <param name="cancellationToken">Маркёр отмены</param>
        /// <returns></returns>
        [Theory]
        [AutoData]
        public async Task Update_Throws_Exception_When_Category_Is_Null(
            CongratulationUpdateRequest request,
            List<IFormFile> files,
            CancellationToken cancellationToken)
        {
            // Arrange

            // Чтобы пройти валидацию, правим tags
            request.TagBodies = new string[3] { "111", "222", "333" };

            // "Возвращаем" польователя, который "восстанавливает" это объявление
            _userProviderMock
                .Setup(_ => _.GetUserId())
                .Returns("24cb4b25-c819-45ab-8755-d95120fbb868") // возвращает в результате выполнения
                .Verifiable(); // Verify all verifiable expectations on all mocks created through the repository

            // Чтобы вернуть пустую категорию
            Domain.Category category = null;
            _categoryRepositoryMock
                .Setup(_ => _.FindById(
                    It.IsAny<int?>(), // проверяет, что параметр имеет указанный тип <>
                    It.IsAny<CancellationToken>())) // проверяет, что параметр имеет указанный тип <>
                .ReturnsAsync(category) // в результате выполнения возвращает объект
                .Verifiable(); // Verify all verifiable expectations on all mocks created through the repository

            // Объект объявления, который "возвращается" из базы
            var congratulation = new Domain.Congratulation()
            {
                OwnerId = "24cb4b25-c819-45ab-8755-d95120fbb868"
            };
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
            await Assert.ThrowsAsync<CategoryNotFoundException>(
                async () => await _advertisementServiceV1.Update(
                    request,
                    files,
                    cancellationToken));
        }
    }
}