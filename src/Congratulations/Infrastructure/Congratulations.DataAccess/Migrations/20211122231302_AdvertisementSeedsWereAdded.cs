using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Congratulations.DataAccess.Migrations
{
    public partial class CongratulationSeedsWereAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Count",
                table: "Tags");

            migrationBuilder.UpdateData(
                table: "Congratulations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Body", "CategoryId", "CreatedAt", "Price", "Title" },
                values: new object[] { "Совокупность всех видов путей сообщения, транспортных средств, технических устройств и сооружений на путях сообщения, обеспечивающих процесс перемещения людей и грузов различного назначения из одного места в другое", 2, new DateTime(2021, 11, 22, 23, 13, 2, 6, DateTimeKind.Utc).AddTicks(9406), 100m, "Продам транспорт" });

            migrationBuilder.UpdateData(
                table: "Congratulations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Body", "CategoryId", "CreatedAt", "Price", "Title" },
                values: new object[] { "Основное назначение автомобиля заключается в совершении транспортной работы. Автомобильный транспорт в промышленно развитых странах занимает ведущее место по сравнению с другими видами транспорта по объёму перевозок пассажиров. Современный автомобиль состоит из 15—20 тысяч деталей, из которых 150—300 являются наиболее важными и требующими наибольших затрат в эксплуатации", 2, new DateTime(2021, 11, 22, 23, 13, 2, 6, DateTimeKind.Utc).AddTicks(9707), 400m, "Продам автомобиль" });

            migrationBuilder.UpdateData(
                table: "Congratulations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Body", "CategoryId", "CreatedAt", "Price", "Title" },
                values: new object[] { "Классические мотоциклы включают в себя двухколёсные, двухколёсные с боковой коляской, и трёхколёсные; в начале XXI века стали набирать популярность квадроциклы. Мотоциклы также подазделяются по своей конструкции и размерам: мопеды, мокики (имеют небольшой размер двигателя, как правило до 50 см³)", 3, new DateTime(2021, 11, 22, 23, 13, 2, 6, DateTimeKind.Utc).AddTicks(9710), 900m, "Продам мотоцикл" });

            migrationBuilder.UpdateData(
                table: "Congratulations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Body", "CategoryId", "CreatedAt", "Price", "Title" },
                values: new object[] { "Классические мотоциклы включают в себя двухколёсные, двухколёсные с боковой коляской, и трёхколёсные; в начале XXI века стали набирать популярность квадроциклы. Мотоциклы также подазделяются по своей конструкции и размерам: мопеды, мокики (имеют небольшой размер двигателя, как правило до 50 см³)", 3, new DateTime(2021, 11, 22, 23, 13, 2, 6, DateTimeKind.Utc).AddTicks(9711), 1600m, "Продам мототехнику б/у" });

            migrationBuilder.UpdateData(
                table: "Congratulations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Body", "CategoryId", "CreatedAt", "Price", "Title" },
                values: new object[] { "Грузовой автомобиль (разг. грузовик) — автомобиль, предназначенный для перевозки грузов в кузове или на грузовой платформе. Для обобщённого обозначения машин, созданных на базе грузового автомобиля, используется термин грузовая техника.", 4, new DateTime(2021, 11, 22, 23, 13, 2, 6, DateTimeKind.Utc).AddTicks(9712), 2500m, "Продам грузовик б/у" });

            migrationBuilder.UpdateData(
                table: "Congratulations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Body", "CategoryId", "CreatedAt", "Price", "Title" },
                values: new object[] { "За считанные месяцы были разработаны, изготовлены и подготовлены к участию во Всесоюзном мотопробеге пять мотоциклов пяти различных моделей. Наиболее удачными были мотоциклы — колоссы «Иж-1» и «Иж-2» с двухцилиндровыми V-образными двигателями рабочим объёмом 1200 см³ и максимальной мощностью 24 л. с. Для своего времени это были чрезвычайно оригинальные и передовые конструкции. Коленчатый вал двигателя располагался продольно, крутящий момент на заднее колесо передавался от трёхступенчатой коробки передач,", 4, new DateTime(2021, 11, 22, 23, 13, 2, 6, DateTimeKind.Utc).AddTicks(9713), 3600m, "Продам спецтехнику" });

            migrationBuilder.UpdateData(
                table: "Congratulations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Body", "CategoryId", "CreatedAt", "Price", "Title" },
                values: new object[] { "Недви́жимость — вид имущества, признаваемого в законодательном порядке недвижимым. К недвижимости по происхождению относятся земельные участки, участки недр и все, что прочно связано с землёй, то есть объекты, перемещение которых без несоразмерного ущерба их назначению невозможно, в том числе здания, сооружения, объекты незавершённого строительства.", 6, new DateTime(2021, 11, 22, 23, 13, 2, 6, DateTimeKind.Utc).AddTicks(9715), 4900m, "Продам недвижимость" });

            migrationBuilder.UpdateData(
                table: "Congratulations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Body", "CategoryId", "CreatedAt", "Price", "Title" },
                values: new object[] { "Кварти́ра (от нем. Quartier[1]) — один из видов жилого помещения, состоящий из одной или нескольких смежных комнат а также в отдельных случаях с отдельным наружным выходом, составляющее отдельную часть дома.", 6, new DateTime(2021, 11, 22, 23, 13, 2, 6, DateTimeKind.Utc).AddTicks(9716), 6400m, "Продам квартиру" });

            migrationBuilder.UpdateData(
                table: "Congratulations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Body", "CategoryId", "CreatedAt", "Price", "Title" },
                values: new object[] { "Кварти́ра (от нем. Quartier[1]) — один из видов жилого помещения, состоящий из одной или нескольких смежных комнат а также в отдельных случаях с отдельным наружным выходом, составляющее отдельную часть дома.", 7, new DateTime(2021, 11, 22, 23, 13, 2, 6, DateTimeKind.Utc).AddTicks(9717), 8100m, "Продам комнату" });

            migrationBuilder.UpdateData(
                table: "Congratulations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Body", "CategoryId", "CreatedAt", "Price", "Title" },
                values: new object[] { "Котте́дж (от англ. cottage) — индивидуальный городской или сельский малоэтажный (обычно двухэтажный) жилой дом с небольшим участком прилегающей земли[1] для постоянного или временного проживания одной нуклеарной семьи. Первый этаж занимают такие помещения как гостиная, кухня, санузел, котельная, часто гараж для легкового автомобиля;", 8, new DateTime(2021, 11, 22, 23, 13, 2, 6, DateTimeKind.Utc).AddTicks(9718), 10000m, "Продам дом" });

            migrationBuilder.UpdateData(
                table: "Congratulations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Body", "CategoryId", "CreatedAt", "Price", "Title" },
                values: new object[] { "Котте́дж (от англ. cottage) — индивидуальный городской или сельский малоэтажный (обычно двухэтажный) жилой дом с небольшим участком прилегающей земли[1] для постоянного или временного проживания одной нуклеарной семьи. Первый этаж занимают такие помещения как гостиная, кухня, санузел, котельная, часто гараж для легкового автомобиля;", 8, new DateTime(2021, 11, 22, 23, 13, 2, 6, DateTimeKind.Utc).AddTicks(9720), 12100m, "Продам дачу" });

            migrationBuilder.UpdateData(
                table: "Congratulations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Body", "CategoryId", "CreatedAt", "Price", "Title" },
                values: new object[] { "Котте́дж (от англ. cottage) — индивидуальный городской или сельский малоэтажный (обычно двухэтажный) жилой дом с небольшим участком прилегающей земли[1] для постоянного или временного проживания одной нуклеарной семьи. Первый этаж занимают такие помещения как гостиная, кухня, санузел, котельная, часто гараж для легкового автомобиля;", 8, new DateTime(2021, 11, 22, 23, 13, 2, 6, DateTimeKind.Utc).AddTicks(9721), 14400m, "Продам котедж" });

            migrationBuilder.UpdateData(
                table: "Congratulations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Body", "CreatedAt", "Price", "Title" },
                values: new object[] { "Возникновению электроники предшествовало открытие и изучение электричества, электромагнетизма, а далее изобретение радио. Поскольку радиопередатчики сразу же нашли применение (в первую очередь на кораблях и в военном деле), для них потребовалась элементная база, созданием и изучением которой и занялась электроника. Элементная база первого поколения была основана на электронных лампах. Соответственно получила развитие вакуумная электроника. Её развитию способствовало также изобретение телевидения и радаров, которые нашли широкое применение во время Второй мировой войны[2][3].Но электронные лампы обладали существенными недостатками. ", new DateTime(2021, 11, 22, 23, 13, 2, 6, DateTimeKind.Utc).AddTicks(9722), 16900m, "Продам электронику" });

            migrationBuilder.UpdateData(
                table: "Congratulations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Body", "CreatedAt", "Price", "Title" },
                values: new object[] { "Аудиотехника (звуковая техника, звукотехника, аудиоэлектроника) — аппаратура (магнитофоны, ревербераторы, микшеры, усилители, ресиверы и пр.) и устройства (микрофоны, динамики и пр.), предназначенные для записи и воспроизведения аудио (звука).", new DateTime(2021, 11, 22, 23, 13, 2, 6, DateTimeKind.Utc).AddTicks(9723), 19600m, "Продам аудиотехнику б/у" });

            migrationBuilder.UpdateData(
                table: "Congratulations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Body", "CreatedAt", "Price", "Title" },
                values: new object[] { "В середине 1980-х годов в СССР начали выпускать первые бытовые VHS- видеомагнитофоны «Электроника ВМ-12», которые стоили 1200 рублей (7-10 средних зарплат того времени[13]), но были дефицитным товаром и продавались по предварительной записи. Существовало даже такое понятие, как очередь на видеомагнитофон.", new DateTime(2021, 11, 22, 23, 13, 2, 6, DateTimeKind.Utc).AddTicks(9724), 22500m, "Продам видеотехнику б/у" });

            migrationBuilder.UpdateData(
                table: "Congratulations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Body", "CategoryId", "CreatedAt", "Price", "Title" },
                values: new object[] { "Игрова́я приста́вка (игровая консоль) — специализированное электронное устройство, предназначенное для видеоигр; для таких устройств, в отличие от персональных компьютеров, запуск и воспроизв", 11, new DateTime(2021, 11, 22, 23, 13, 2, 6, DateTimeKind.Utc).AddTicks(9726), 25600m, "Продам игру" });

            migrationBuilder.UpdateData(
                table: "Congratulations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Body", "CategoryId", "CreatedAt", "Price", "Title" },
                values: new object[] { "Игрова́я приста́вка (игровая консоль) — специализированное электронное устройство, предназначенное для видеоигр; для таких устройств, в отличие от персональных компьютеров, запуск и воспроизв", 11, new DateTime(2021, 11, 22, 23, 13, 2, 6, DateTimeKind.Utc).AddTicks(9727), 28900m, "Продам приставку" });

            migrationBuilder.UpdateData(
                table: "Congratulations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Body", "CategoryId", "CreatedAt", "Price", "Title" },
                values: new object[] { "Игрова́я приста́вка (игровая консоль) — специализированное электронное устройство, предназначенное для видеоигр; для таких устройств, в отличие от персональных компьютеров, запуск и воспроизв", 11, new DateTime(2021, 11, 22, 23, 13, 2, 6, DateTimeKind.Utc).AddTicks(9728), 32400m, "Продам программу" });

            migrationBuilder.UpdateData(
                table: "Congratulations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Body", "CategoryId", "CreatedAt", "Price", "Title" },
                values: new object[] { "Насто́льный (стационарный) компью́тер, дескто́п (англ. desktop computer) — стационарный персональный компьютер, предназначенный для работы в офисе и дома. Термин обычно используется для того, чтобы обозначить вид компьютера и отличить его от компьютеров других типов, например портативного компьютера, карманного компьютера, встроенного компьютера или сервера. Как правило, состоит из монитора, системного блока, мыши, клавиатуры и звукогарнитуры", 12, new DateTime(2021, 11, 22, 23, 13, 2, 6, DateTimeKind.Utc).AddTicks(9729), 36100m, "Продам настольный компьютер б/у" });

            migrationBuilder.UpdateData(
                table: "Congratulations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Body", "CategoryId", "CreatedAt", "Title" },
                values: new object[] { "Переносной компьютер, в корпусе которого объединены типичные компоненты ПК, включая дисплей, клавиатуру и устройство указания (обычно сенсорная панель или тачпад), а также аккумуляторные батареи. Ноутбуки отличаются небольшими размерами и весом, время автономной работы ноутбуков варьируется в пределах от 2 до 15 часов.", 13, new DateTime(2021, 11, 22, 23, 13, 2, 6, DateTimeKind.Utc).AddTicks(9730), "Продам ноутбук" });

            migrationBuilder.InsertData(
                table: "Congratulations",
                columns: new[] { "Id", "Address", "Body", "CategoryId", "CreatedAt", "IsDeleted", "OwnerId", "Price", "RegionId", "Status", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 21, "297415 г. Чебоксары, ул. Толстого, 25", "Интернет-планшет (англ. Internet tablet или Web tablet — Веб-планшет, или Pad tablet — Pad-планшет (Блокнотный планшет), или Web-pad — Веб-блокнот, или Surfpad — Веб-сёрфинг-блокнот) — мобильный компьютер, относящийся к типу планшетных компьютеров с диагональю экрана от 7 до 12 дюймов, построенный на аппаратной платформе того же класса, что и платформа для смартфонов.", 14, new DateTime(2021, 11, 22, 23, 13, 2, 6, DateTimeKind.Utc).AddTicks(9732), false, "64dbb199-0a95-4f1a-afcf-10cc827fd3c8", 44100m, 21, 0, "Продам планшет", null },
                    { 25, "295314 г. Симферополь, ул. Чернышевского, 4", "Фотоаппара́т (фотографи́ческий аппара́т, фотока́мера) — устройство для регистрации неподвижных изображений (получения фотографий). Запись изображения в фотоаппарате осуществляется фотохимическим способом при воздействии света на светочувствительный фотоматериал. Получаемое таким способом скрытое изображение преобразуется в видимое при лабораторной обработке. В цифровом фотоаппарате фотофиксация происходит путём фотоэлектрического преобразования оптического изображения в электрический сигнал, цифровые данные о котором сохраняются на энергонезависимом носителе.", 17, new DateTime(2021, 11, 22, 23, 13, 2, 6, DateTimeKind.Utc).AddTicks(9736), false, "7e24ccd2-34fd-4289-9a78-1aae93623bae", 62500m, 25, 0, "Продам фотоаппарат б/у", null },
                    { 24, "293713 г. Керчь, ул. Куприна, 3", "Комплементарные блага (взаимодополняющие товары) — блага, совместное потребление которых является для агента более предпочтительным, чем потребление каждого", 16, new DateTime(2021, 11, 22, 23, 13, 2, 6, DateTimeKind.Utc).AddTicks(9735), false, "09c529c8-e798-44ac-9eac-e0150182fa4c", 57600m, 24, 0, "Продам товары для компьютера", null },
                    { 23, "299812 г. Судак, ул. Сергеева, 2", "С точки зрения экономики и общества возможность осуществления телефонных переговоров рассматривается как благо и важное условие комфортной жизни человека. Существует область науки и техники, связанная с изучением направлений развития телефонной связи, она получила название телефонии.", 15, new DateTime(2021, 11, 22, 23, 13, 2, 6, DateTimeKind.Utc).AddTicks(9734), false, "c191e5f8-bf5b-40a9-9ab6-4d08704e373b", 52900m, 23, 0, "Продам телефон", null },
                    { 22, "299411 г. Москва, ул. Тургенева, 1", "Электро́нная кни́га (Electronic book; e-book; eBook) — версия книги, хранящаяся в электронном виде, и показываемая на экране, в цифровом формате. Данное понятие применяется как для произведений, представленных в цифровой форме, так и в отношении устройств, используемых для их прочтения.", 14, new DateTime(2021, 11, 22, 23, 13, 2, 6, DateTimeKind.Utc).AddTicks(9733), false, "54b1ff98-6b5f-4c5e-97a9-747095e1f5dc", 48400m, 22, 0, "Продам электронную книгу", null }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 19, DateTimeKind.Utc).AddTicks(4691));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 19, DateTimeKind.Utc).AddTicks(5221));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 19, DateTimeKind.Utc).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 19, DateTimeKind.Utc).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 19, DateTimeKind.Utc).AddTicks(5481));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 19, DateTimeKind.Utc).AddTicks(5482));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 19, DateTimeKind.Utc).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 19, DateTimeKind.Utc).AddTicks(5485));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 19, DateTimeKind.Utc).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 19, DateTimeKind.Utc).AddTicks(5487));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 19, DateTimeKind.Utc).AddTicks(5488));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 19, DateTimeKind.Utc).AddTicks(5489));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 19, DateTimeKind.Utc).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 19, DateTimeKind.Utc).AddTicks(5491));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 19, DateTimeKind.Utc).AddTicks(5492));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 19, DateTimeKind.Utc).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 19, DateTimeKind.Utc).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(8894));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9187));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9188));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9189));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9190));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9191));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9192));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9193));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9194));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9195));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9196));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9197));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9198));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9199));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9200));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9201));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9202));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9203));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9203));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9204));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9206));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9207));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9208));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9209));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9211));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9212));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9213));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9215));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9216));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9217));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9218));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9219));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9219));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9220));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9221));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9222));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9223));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9224));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9225));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9226));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9227));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9229));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9233));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9234));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9235));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9236));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9237));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9239));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9241));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9242));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9243));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9244));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9245));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9247));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9248));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9249));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9252));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9254));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9255));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9255));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9256));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9257));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9259));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9261));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9262));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9263));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9264));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9265));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9266));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9267));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9268));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9269));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9270));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9271));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9271));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9272));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9312));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9313));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9314));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9315));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9316));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 22, 23, 13, 2, 23, DateTimeKind.Utc).AddTicks(9317));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Congratulations",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Congratulations",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Congratulations",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Congratulations",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Congratulations",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "Tags",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Congratulations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Body", "CategoryId", "CreatedAt", "Price", "Title" },
                values: new object[] { "Телевизор Xiaomi Mi TV 4S 50, 50, Ultra HD 4K", 10, new DateTime(2021, 11, 18, 9, 21, 51, 132, DateTimeKind.Utc).AddTicks(5983), 40000m, "Продам телевизор" });

            migrationBuilder.UpdateData(
                table: "Congratulations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Body", "CategoryId", "CreatedAt", "Price", "Title" },
                values: new object[] { "Телевизор Xiaomi Mi TV 4S 50, 50, Ultra HD 4K", 10, new DateTime(2021, 11, 18, 9, 21, 51, 132, DateTimeKind.Utc).AddTicks(6447), 40000m, "Продам телевизор" });

            migrationBuilder.UpdateData(
                table: "Congratulations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Body", "CategoryId", "CreatedAt", "Price", "Title" },
                values: new object[] { "Телевизор Xiaomi Mi TV 4S 50, 50, Ultra HD 4K", 10, new DateTime(2021, 11, 18, 9, 21, 51, 132, DateTimeKind.Utc).AddTicks(6450), 40000m, "Продам телевизор" });

            migrationBuilder.UpdateData(
                table: "Congratulations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Body", "CategoryId", "CreatedAt", "Price", "Title" },
                values: new object[] { "Телевизор Xiaomi Mi TV 4S 50, 50, Ultra HD 4K", 10, new DateTime(2021, 11, 18, 9, 21, 51, 132, DateTimeKind.Utc).AddTicks(6451), 40000m, "Продам телевизор" });

            migrationBuilder.UpdateData(
                table: "Congratulations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Body", "CategoryId", "CreatedAt", "Price", "Title" },
                values: new object[] { "Телевизор Xiaomi Mi TV 4S 50, 50, Ultra HD 4K", 10, new DateTime(2021, 11, 18, 9, 21, 51, 132, DateTimeKind.Utc).AddTicks(6453), 40000m, "Продам телевизор" });

            migrationBuilder.UpdateData(
                table: "Congratulations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Body", "CategoryId", "CreatedAt", "Price", "Title" },
                values: new object[] { "Телевизор Xiaomi Mi TV 4S 50, 50, Ultra HD 4K", 10, new DateTime(2021, 11, 18, 9, 21, 51, 132, DateTimeKind.Utc).AddTicks(6454), 40000m, "Продам телевизор" });

            migrationBuilder.UpdateData(
                table: "Congratulations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Body", "CategoryId", "CreatedAt", "Price", "Title" },
                values: new object[] { "Телевизор Xiaomi Mi TV 4S 50, 50, Ultra HD 4K", 10, new DateTime(2021, 11, 18, 9, 21, 51, 132, DateTimeKind.Utc).AddTicks(6455), 40000m, "Продам телевизор" });

            migrationBuilder.UpdateData(
                table: "Congratulations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Body", "CategoryId", "CreatedAt", "Price", "Title" },
                values: new object[] { "Телевизор Xiaomi Mi TV 4S 50, 50, Ultra HD 4K", 10, new DateTime(2021, 11, 18, 9, 21, 51, 132, DateTimeKind.Utc).AddTicks(6456), 40000m, "Продам телевизор" });

            migrationBuilder.UpdateData(
                table: "Congratulations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Body", "CategoryId", "CreatedAt", "Price", "Title" },
                values: new object[] { "Телевизор Xiaomi Mi TV 4S 50, 50, Ultra HD 4K", 10, new DateTime(2021, 11, 18, 9, 21, 51, 132, DateTimeKind.Utc).AddTicks(6458), 40000m, "Продам телевизор" });

            migrationBuilder.UpdateData(
                table: "Congratulations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Body", "CategoryId", "CreatedAt", "Price", "Title" },
                values: new object[] { "Телевизор Xiaomi Mi TV 4S 50, 50, Ultra HD 4K", 10, new DateTime(2021, 11, 18, 9, 21, 51, 132, DateTimeKind.Utc).AddTicks(6459), 40000m, "Продам телевизор" });

            migrationBuilder.UpdateData(
                table: "Congratulations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Body", "CategoryId", "CreatedAt", "Price", "Title" },
                values: new object[] { "Телевизор Xiaomi Mi TV 4S 50, 50, Ultra HD 4K", 10, new DateTime(2021, 11, 18, 9, 21, 51, 132, DateTimeKind.Utc).AddTicks(6460), 40000m, "Продам телевизор" });

            migrationBuilder.UpdateData(
                table: "Congratulations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Body", "CategoryId", "CreatedAt", "Price", "Title" },
                values: new object[] { "Телевизор Xiaomi Mi TV 4S 50, 50, Ultra HD 4K", 10, new DateTime(2021, 11, 18, 9, 21, 51, 132, DateTimeKind.Utc).AddTicks(6461), 40000m, "Продам телевизор" });

            migrationBuilder.UpdateData(
                table: "Congratulations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Body", "CreatedAt", "Price", "Title" },
                values: new object[] { "Телевизор Xiaomi Mi TV 4S 50, 50, Ultra HD 4K", new DateTime(2021, 11, 18, 9, 21, 51, 132, DateTimeKind.Utc).AddTicks(6463), 40000m, "Продам телевизор" });

            migrationBuilder.UpdateData(
                table: "Congratulations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Body", "CreatedAt", "Price", "Title" },
                values: new object[] { "Телевизор Xiaomi Mi TV 4S 50, 50, Ultra HD 4K", new DateTime(2021, 11, 18, 9, 21, 51, 132, DateTimeKind.Utc).AddTicks(6464), 40000m, "Продам телевизор" });

            migrationBuilder.UpdateData(
                table: "Congratulations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Body", "CreatedAt", "Price", "Title" },
                values: new object[] { "Телевизор Xiaomi Mi TV 4S 50, 50, Ultra HD 4K", new DateTime(2021, 11, 18, 9, 21, 51, 132, DateTimeKind.Utc).AddTicks(6465), 40000m, "Продам телевизор" });

            migrationBuilder.UpdateData(
                table: "Congratulations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Body", "CategoryId", "CreatedAt", "Price", "Title" },
                values: new object[] { "Телевизор Xiaomi Mi TV 4S 50, 50, Ultra HD 4K", 10, new DateTime(2021, 11, 18, 9, 21, 51, 132, DateTimeKind.Utc).AddTicks(6466), 40000m, "Продам телевизор" });

            migrationBuilder.UpdateData(
                table: "Congratulations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Body", "CategoryId", "CreatedAt", "Price", "Title" },
                values: new object[] { "Телевизор Xiaomi Mi TV 4S 50, 50, Ultra HD 4K", 10, new DateTime(2021, 11, 18, 9, 21, 51, 132, DateTimeKind.Utc).AddTicks(6468), 40000m, "Продам телевизор" });

            migrationBuilder.UpdateData(
                table: "Congratulations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Body", "CategoryId", "CreatedAt", "Price", "Title" },
                values: new object[] { "Телевизор Xiaomi Mi TV 4S 50, 50, Ultra HD 4K", 10, new DateTime(2021, 11, 18, 9, 21, 51, 132, DateTimeKind.Utc).AddTicks(6469), 40000m, "Продам телевизор" });

            migrationBuilder.UpdateData(
                table: "Congratulations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Body", "CategoryId", "CreatedAt", "Price", "Title" },
                values: new object[] { "Телевизор Xiaomi Mi TV 4S 50, 50, Ultra HD 4K", 10, new DateTime(2021, 11, 18, 9, 21, 51, 132, DateTimeKind.Utc).AddTicks(6470), 40000m, "Продам телевизор" });

            migrationBuilder.UpdateData(
                table: "Congratulations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Body", "CategoryId", "CreatedAt", "Title" },
                values: new object[] { "Телевизор Xiaomi Mi TV 4S 50, 50, Ultra HD 4K", 10, new DateTime(2021, 11, 18, 9, 21, 51, 132, DateTimeKind.Utc).AddTicks(6471), "Продам телевизор" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 148, DateTimeKind.Utc).AddTicks(6653));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 148, DateTimeKind.Utc).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 148, DateTimeKind.Utc).AddTicks(7557));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 148, DateTimeKind.Utc).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 148, DateTimeKind.Utc).AddTicks(7561));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 148, DateTimeKind.Utc).AddTicks(7966));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 148, DateTimeKind.Utc).AddTicks(7969));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 148, DateTimeKind.Utc).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 148, DateTimeKind.Utc).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 148, DateTimeKind.Utc).AddTicks(7972));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 148, DateTimeKind.Utc).AddTicks(7974));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 148, DateTimeKind.Utc).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 148, DateTimeKind.Utc).AddTicks(7976));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 148, DateTimeKind.Utc).AddTicks(7977));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 148, DateTimeKind.Utc).AddTicks(7978));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 148, DateTimeKind.Utc).AddTicks(7979));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 148, DateTimeKind.Utc).AddTicks(7980));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9297));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9744));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9746));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9747));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9749));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9752));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9753));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9754));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9755));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9756));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9757));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9759));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9761));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9762));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9763));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9764));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9765));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9766));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9767));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9768));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9769));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9770));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9772));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9773));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9774));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9775));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9776));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9777));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9778));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9779));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9781));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9782));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9783));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9786));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9787));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9789));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9790));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9791));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9793));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9794));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9795));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9797));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9798));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9799));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9801));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9802));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9803));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9805));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9806));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9807));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9808));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9809));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9811));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9812));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9813));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9814));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9815));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9849));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9852));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9853));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9854));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9855));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9857));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9858));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9859));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9861));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9862));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9863));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9864));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9865));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9866));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9867));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9868));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9869));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9870));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9871));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9872));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9873));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9874));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9875));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9876));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9877));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9878));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9879));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 18, 9, 21, 51, 153, DateTimeKind.Utc).AddTicks(9881));
        }
    }
}
