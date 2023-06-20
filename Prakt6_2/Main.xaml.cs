using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using Xamarin.Forms;

namespace Prakt6_2
{
    public partial class Main : ContentPage
    {
        private int selectedQuantity;
        private List<Movie> movies;
        private async void OnQuantitySelected(object sender, int quantity)
        {
            selectedQuantity = quantity;
            await Navigation.PopAsync();
        }
        public Main ()
        {
            InitializeComponent();

            movies = new List<Movie>
            {
                new Movie
                {
                    Title = "Один дома (1990)",
                    Studio = "«Гемини-Фильм»",
                     Category = "комедия, семейный",
                    Capacity =155,
                    Theater = "Салют",
                    Hall = "Большой",
                    Seat = "1",
                    Time = "12:20",
                    Date = System.DateTime.Today,
                    Director = "Крис Коламбус",
                    Year= 1990,
                    Country = "США",
                    Summary = "Американское семейство отправляется из Чикаго в Европу, но в спешке сборов бестолковые родители забывают дома... одного из своих детей. Юное создание, однако, не теряется и демонстрирует чудеса изобретательности. И когда в дом залезают грабители, им приходится не раз пожалеть о встрече с милым крошкой.",
                    TicketPrice = 150,
                    ImagePath = "movie_1.png"


                },
                new Movie
                {
                     Title = "Иван Васильевич меняет профессию (1973)",
                    Studio = "«Парадиз»",
                    Category = "комедия, фантастика, приключения",
                    Capacity =125,
                    Theater = "Колизей",
                    Hall = "Средний",
                    Seat = "3",
                    Time = "6:00",
                    Date = System.DateTime.Today,
                    Director = "Леонид Гайдай",
                    Year= 1973,
                    Country = "СССР",
                    Summary = "Инженер-изобретатель Тимофеев сконструировал машину времени, которая соединила его квартиру с далеким шестнадцатым веком - точнее, с палатами государя Ивана Грозного. Туда-то и попадают тезка царя пенсионер-общественник Иван Васильевич Бунша и квартирный вор Жорж Милославский.\r\n\r\nНа их место в двадцатом веке «переселяется» великий государь. Поломка машины приводит ко множеству неожиданных и забавных событий...",
                    TicketPrice = 250,
                    ImagePath = "movie_2.jpg"

                },
                new Movie
                {
                     Title = "Операция «Ы» и другие приключения Шурика (1965)",
                    Studio = "«Парадиз»",
                    Category = "Боевик/Фэнтези",
                    Capacity =550,
                    Theater = "Парк-Хаус",
                    Hall = "Большой",
                    Seat = "9",
                    Time = "8:00",
                    Date = System.DateTime.Today,
                   Director = "Леонид Гайдай",
                    Year= 1965,
                    Country = "СССР",
                    Summary = "Студент Шурик попадает в самые невероятные ситуации: сражается с хулиганом Верзилой, весьма оригинальным способом готовится к экзамену и предотвращает «ограбление века», на которое идёт троица бандитов — Балбес, Трус и Бывалый.",
                    TicketPrice = 450,
                    ImagePath = "movie_3.jpg"
                },
                new Movie
                {
                     Title = "Джентльмены удачи (1971)",
                   Studio = "«Парадиз»",
                    Category = "комедия, драма, криминал, детектив",
                    Capacity =300,
                    Theater = "Аида",
                    Hall = "Средний",
                    Seat = "2",
                    Time = "18:00",
                    Date = System.DateTime.Today,
                    Director = "Александр Серый",
                    Year= 1971,
                    Country = "США",
                    Summary = "Заведующему детсадом Трошкину фатально не повезло: он оказался как две капли воды похож на бандита по кличке «Доцент», похитившего уникальный шлем Александра Македонского.\r\n\r\nМилиция внедряет добряка Трошкина в воровскую среду - и ему ничего не остается, кроме как старательно изображать своего двойника-злодея, путая всех окружающих. Со временем он настолько блестяще входит в роль, что сам начинает порой приходить в ужас. Между тем, жизни его угрожает смертельная опасность...",
                    TicketPrice = 500,
                    ImagePath = "movie_4.jpg"

                },
                new Movie
                {
                     Title = "Бриллиантовая рука (1968)",
                    Studio = "«Азимут»",
                    Category = "комедия, криминал",
                    Capacity =400,
                    Theater = "Колизей",
                    Hall = "Большой",
                    Seat = "3",
                    Time = "2:00",
                    Date = System.DateTime.Today,
                    Director = "Леонид Гайдай",
                    Year= 1968,
                    Country = "СССР",
                    Summary = "В южном городке орудует шайка валютчиков, возглавляемая Шефом и его помощником Графом (в быту — Геной Козодоевым). Скромный советский служащий и примерный семьянин Семен Семенович Горбунков отправляется в зарубежный круиз на теплоходе, где также плывет Граф, который должен забрать бриллианты в одном из восточных городов и провезти их в загипсованной руке. Но из-за недоразумения вместо жулика на условленном месте падает ничего не подозревающий Семен Семенович, и драгоценный гипс накладывают ему.",
                    TicketPrice = 345,
                    ImagePath = "movie_5.jpg"

                },
                 new Movie
                {
                     Title = "Кавказская пленница, или Новые приключения Шурика (1966)",
                   Studio = "«Парадиз»",
                    Category = "комедия, приключения, мелодрама, мюзикл",
                    Capacity =220,
                    Theater = "Парк-Хаус",
                    Hall = "Средний",
                    Seat = "3",
                    Time = "11:00",
                    Date = System.DateTime.Today,
                    Director = "Леонид Гайдай",
                    Year= 1966,
                    Country = "СССР",
                    Summary = "Отправившись в одну из горных республик собирать фольклор, студент Шурик влюбляется в симпатичную девушку Нину - спортсменку, отличницу, комсомолку и просто красавицу. Но её внезапно похищают банда их трёх человек, чтобы насильно выдать замуж. Наивный Шурик не сразу сообразил, что творится у него под носом, - однако затем отважно ринулся освобождать кавказскую пленницу.",
                    TicketPrice = 234,
                    ImagePath = "movie_6.jpg"

                },
                 new Movie
                {
                    Title = "Один дома 2: Затерянный в Нью-Йорке (1992)",
                    Studio = "«Гемини-Фильм»",
                    Category = "комедия, семейный, приключения",
                    Capacity = 150,
                    Theater = "Колизей",
                    Hall = "Большой",
                    Seat = "3",
                    Time = "16:30",
                    Date = System.DateTime.Today,
                    Director = "Крис Коламбус",
                    Year = 1992,
                    Country = "США",
                    Summary = "Самый маленький герой Америки устраивает большой переполох в Нью-Йорке! Кевин МакКалистер вернулся! Но теперь он один не дома, а в Нью-Йорке и у него достаточно денег и кредитных карточек, чтобы превратить Большое Яблоко в собственную площадку для игр.\r\n\r\nНо, как всегда, Кевину не суждено быть долго одному: его старые приятели ― жулики Гарри и Марв ― сбежали из тюрьмы, куда они попали стараниями Кевина. И надо же им было попасть именно в тот город, где Кевин планировал поразвлечься! Новые западни и ловушки уже ждут горе-бандитов.",
                    TicketPrice = 180,
                    ImagePath = "movie_7.png"
                },
                new Movie
            {
                Title = "Круэлла (2021)",
                Studio = "«Дисней Студиос»",
                Category = "комедия, криминал, драма",
                Capacity = 180,
                Theater = "Аида",
                Hall = "Большой",
                Seat = "3",
                Time = "21:00",
                Date = System.DateTime.Today,
                Director = "Крэйг Гиллеспи",
                Year = 2021,
                Country = "США, Великобритания",
                Summary = "Великобритания, 1960-е годы. Эстелла была необычным ребёнком, и особенно трудно ей было мириться со всякого рода несправедливостью. Вылетев из очередной школы, она с мамой отправляется в Лондон. По дороге они заезжают в особняк известной модельерши по имени Баронесса, где в результате ужасного несчастного случая мама погибает. Добравшись до Лондона, Эстелла знакомится с двумя мальчишками — уличными мошенниками Джаспером и Хорасом.\r\n\r\n10 лет спустя та же компания промышляет на улицах британской столицы мелким воровством, но Эстелла никак не может оставить мечту сделать карьеру в мире моды. Хитростью устроившись в фешенебельный универмаг, девушка привлекает внимание Баронессы, и та берёт её к себе в штат дизайнеров.",
                TicketPrice = 200,
                ImagePath = "movie_8.png"
            },
                new Movie
            {
                Title = "Батя (2020)",
                Studio = "«Централ Партнершип»",
                Category = "комедия, мелодрама",
                Capacity = 200,
                Theater = "Аида",
                Hall = "Средний",
                Seat = "1",
                Time = "11:00",
                Date = System.DateTime.Today,
                Director = "Дмитрий Ефимович",
                Year = 2020,
                Country = "Россия",
                Summary = "История о путешествии взрослого героя к своему Бате, суровому русскому мужику, который стал отцом на заре девяностых и воспитывал своего сына так, как это делали все советские люди.",
                TicketPrice = 170,
                ImagePath = "movie_9.png"
            },
            new Movie
            {
                Title = "Маска (1994)",
                Studio = "Marvel",
                Category = "комедия, фэнтези, криминал",
                Capacity = 180,
                Theater = "Аида",
                Hall = "Средний",
                Seat = "1",
                Time = "21:00",
                Date = System.DateTime.Today,
                Director = "Чак Рассел",
                Year = 1994,
                Country = "США",
                Summary = "Скромный и застенчивый служащий банка чувствует себя неуверенно с красивыми девушками и вообще рядом с людьми. Волей судьбы к нему попадает волшебная маска, и Стенли Ипкис приобретает способность превращаться в неуязвимое мультяшное существо с озорным характером.",
                TicketPrice = 190,
                ImagePath = "movie_10.png"

        },
            new Movie
            {
                Title = "Отель «Гранд Будапешт» (2014)",
                Studio = "«Двадцатый Век Фокс СНГ»",
                Category = "драма, криминал, биография, комедия",
                Capacity = 200,
                Theater = "Аида",
                Hall = "Средний",
                Seat = "2",
                Time = "19:30",
                Date = System.DateTime.Today,
                Director = "Уэс Андерсон",
                Year = 2014,
                Country = "США",
                Summary = "Тони Старк сражается с новым мощным врагом, используя свою технологию Железного человека.",
                TicketPrice = 180,
                ImagePath = "movie_11.png"
            },
                        new Movie
            {
                Title = "Лулу и Бриггс (2021)",
                Studio = "«Парадиз»",
                Category = "комедия, драма, приключения",
                Capacity = 180,
                Theater = "Аида",
                Hall = "Большой",
                Seat = "3",
                Time = "21:00",
                Date = DateTime.Today,
                Director = "Рид Каролин, Ченнинг Татум",
                Year = 2021,
                Country = "США",
                Summary = "Профессиональный военный Джексон Бриггс всеми силами пытается вернуться в строй, но из-за травмы головы получает постоянные отказы. Когда умирает один из его сослуживцев, Бриггсу дают задание: с военной базы в штате Вашингтон доставить на похороны в аризонский Ногалес боевую подругу почившего — нервную бельгийскую овчарку Лулу с целым спектром посттравматических расстройств. Поскольку собака боится летать, сделать это придётся на машине по Тихоокеанскому побережью, и эта поездка будет не самым простым заданием Бриггса.",
                TicketPrice = 200,
                ImagePath = "movie_12.png"
            },
                        new Movie
            {
                Title = "Последний богатырь (2017)",
                Studio = "«START»",
                Category = "комедия, фэнтези, приключения, семейный",
                Capacity = 160,
                Theater = "Аида",
                Hall = "Средний",
                Seat = "5",
                Time = "19:30",
                Date = DateTime.Today,
                Director = "Дмитрий Дьяченко",
                Year = 2010,
                Country = "Россия",
                Summary = "Победитель 5-го сезона «Битвы магов» белый маг Святозар, а на самом деле — обычный парень Иван, привычно пудрит мозги телезрителям и доверчивым клиентам, готовым поверить во что угодно. Однажды, спасаясь бегством от крепких охранников мужа очередной одураченной им домохозяйки, парень внезапно переносится из Москвы в сказочную страну Белогорье. А встреченный там старец объявляет Ивану, что тот — сын Ильи Муромца, и только он может их спасти. Так наш «белый маг» оказывается в эпицентре противостояния волшебных сил добра и зла, вот только сам парень уверен, что он тут совершенно ни при чём, и всё это — какая-то нелепая ошибка.",
                TicketPrice = 180,
                ImagePath = "movie_13.png"
            },
                        new Movie
            {
                Title = "Мальчишник в Вегасе (2009)",
                Studio = "«Юниверсал Пикчерс Рус»",
                Category = "комедия",
                Capacity = 140,
                Theater = "Аида",
                Hall = "Малый",
                Seat = "2",
                Time = "17:00",
                Date = DateTime.Today,
                Director = "Тодд Филлипс",
                Year = 2009,
                Country = "США",
                Summary = "Они мечтали устроить незабываемый мальчишник в Вегасе. Но теперь им необходимо вспомнить, что именно произошло: что за ребенок сидит в шкафу номера отеля? Как в ванную попал тигр? Почему у одного из них нет зуба? И, самое главное, куда делся жених? То, что парни вытворяли на вечеринке, не идет ни в какое сравнение с тем, что им придется сделать на трезвую голову, когда они будут шаг за шагом восстанавливать события прошлой ночи.",
                TicketPrice = 150,
                ImagePath = "movie_14.png"
            },
                        new Movie
            {
                Title = "Всегда говори «ДА» (2008)",
                Studio = "«Юниверсал Пикчерс Рус»",
                Category = "Комедия",
                Capacity = 150,
                Theater = "Аида",
                Hall = "Большой",
                Seat = "1",
                Time = "20:00",
                Date = DateTime.Today,
                Director = "Пейтон Рид",
                Year = 2008,
                Country = "США, Великобритания",
                Summary = "Депрессивный главный герой всегда и всем говорил «нет» — например, друзьям, если они зовут куда-то. Но в один прекрасный день он заключает соглашение, по которому всегда должен отвечать «Да» на любое предложение...",
                TicketPrice = 160,
                ImagePath = "movie_15.png"
            }, new Movie
            {
                Title = "Жмурки (2005)",
                Studio = "«Наше Кино»",
                Category = "комедия, криминал",
                Capacity = 140,
                Theater = "Аида",
                Hall = "Средний",
                Seat = "4",
                Time = "19:00",
                Date = DateTime.Today,
                Director = "Алексей Балабанов",
                Year = 2005,
                Country = "Россия",
                Summary = "Жмурки — старинная русская игра: водящий, с завязанными глазами, ловит остальных играющих. К середине 1990-х правила игры изменились: выигрывает тот, кто останется в живых, сделав жмуриками остальных.",
                TicketPrice = 150,
                ImagePath = "movie_16.png"
            },
                        new Movie
            {
                Title = "Мы — Миллеры (2013)",
                Studio = "«CP Дистрибуция»",
                Category = "комедия, криминал",
                Capacity = 160,
                Theater = "Аида",
                Hall = "Малый",
                Seat = "3",
                Time = "21:30",
                Date = DateTime.Today,
                Director = "Роусон Маршалл Тёрбер",
                Year = 2013,
                Country = "США",
                Summary = "Дэвид Кларк — мелкий торговец наркотиками. Среди его клиентов — повара и скучающие домохозяйки. Детям он наркотики не продаёт и поэтому считает себя принципиальным человеком. Дэвид действительно хорошо относится к детям, но это не остается безнаказанным — он пытается помочь подросткам, попавшим в беду, и на него нападают хулиганы-панки. Они отбирают у него наркотики и деньги, и наш герой оказывается в отчаянном положении. Ведь ему нечем расплатиться с его поставщиком Брэдом. Единственный выход — подрядиться на доставку крупной партии наркотиков через границу…",
                TicketPrice = 170,
                ImagePath = "movie_17.png"
            }, 
                new Movie
    {
        Title = "О чём говорят мужчины (2010)",
        Studio = "«Мистерия Звука»",
        Category = "Боевик/Научная фантастика",
        Capacity = 120,
        Theater = "Аида",
        Hall = "Средний",
        Seat = "3",
        Time = "16:30",
        Date = DateTime.Today,
        Director = "Дмитрий Дьяченко",
        Year = 2010,
        Country = "Россия",
        Summary = "Четверо друзей болтают о женщинах, карьере и культуре по дороге на концерт. Роуд-муви по пьесе «Квартета И»",
        TicketPrice = 150,
        ImagePath = "movie_18.png"
    },
                new Movie
    {
        Title = "Зависнуть в Палм-Спрингс (2020)",
        Studio = "«Вольга»",
        Category = "Драма/Криминал",
        Capacity = 110,
        Theater = "Колизей",
        Hall = "Большой",
        Seat = "4",
        Time = "18:00",
        Date = DateTime.Today,
        Director = "Макс Барбаков",
        Year = 2020,
        Country = "США, Гонконг",
        Summary = "9 ноября неподалёку от Палм-Спрингс идёт подготовка к свадьбе. Найлз, парень одной из подружек невесты, не торопится облачаться в смокинг — в шортах и гавайской рубашке он запрыгивает в бассейн и целый день расслабленно выпивает, а вечером произносит трогательную речь для молодожёнов. Последнее особенно впечатляет старшую сестру невесты Сару, и вот уже девушка оказывается с Найлзом наедине под звёздным небом. Но тут события принимают неожиданный поворот, и Сара вслед за своим новым приятелем заходит в загадочную пещеру, а на следующий день обнаруживает, что на календаре снова 9 ноября.",
        TicketPrice = 120,
        ImagePath = "movie_19.png"
    },
    new Movie
    {
        Title = "Добро пожаловать в семью (2021)",
        Studio = "«Arna Media»",
        Category = "комедия, криминал, мелодрама",
        Capacity = 115,
        Theater = "Парк-Хаус",
        Hall = "Средний",
        Seat = "2",
        Time = "20:15",
        Date = DateTime.Today,
        Director = "Владимир Зинкевич",
        Year = 2021,
        Country = "Беларусь",
        Summary = "Леонид Иванович — Крестный отец. В этом мире он любит лишь две вещи: быть Крестным отцом и свою дочь Миру. Чтобы не разгневать босса, Миру все обходят стороной. Кроме Саши, который ничего не знал про семью и просто влюбился с первого взгляда. Теперь у него непростая задача — не лишиться руки и сердца до свадьбы.",
        TicketPrice = 130,
        ImagePath = "movie_20.png"
    },
    


        };
            var titleLabel = new Label
            {
                Text = "Онлайн-кинотеатр (покупка билетов)",
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.Red,
                HorizontalOptions = LayoutOptions.Center,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };

            var listView = new ListView
            {
                ItemTemplate = new DataTemplate(typeof(TextCell)),
                ItemsSource = movies,
                SeparatorVisibility = SeparatorVisibility.Default
            };
            listView.ItemTemplate.SetBinding(TextCell.TextProperty, "Title");
            listView.ItemSelected += OnMovieSelected;
            var quantityButton = new Button
            {
                Text = "Выбор количества билетов",
                BackgroundColor = Color.Gray,
                TextColor = Color.White
            };
            quantityButton.Clicked += async (sender, e) =>
            {
                var selectedMovie = listView.SelectedItem as Movie;
                if (selectedMovie != null)
                {
                    var quantityPage = new Page4(selectedMovie);
                    quantityPage.QuantitySelected += OnQuantitySelected;
                    await Navigation.PushAsync(quantityPage);
                }
                else
                {
                    await DisplayAlert("Ошибка", "Пожалуйста, выберите фильм.", "OK");
                }
            };
            var assembly = typeof(Main).Assembly;
            var costButton = new Button
            {
                Text = "Расчет стоимости билетов",
                BackgroundColor = Color.Gray,
                TextColor = Color.White
            };
            costButton.Clicked += async (sender, e) =>
            {
                var selectedMovie = listView.SelectedItem as Movie;
                if (selectedMovie != null)
                {
                    if (selectedQuantity > 0)
                    {
                        var costPage = new Page3(selectedMovie.TicketPrice, selectedMovie, selectedQuantity);
                        await Navigation.PushModalAsync(costPage);
                    }
                    else
                    {
                        selectedQuantity = 1;
                        var costPage = new Page3(selectedMovie.TicketPrice, selectedMovie, selectedQuantity);
                        await Navigation.PushModalAsync(costPage);
                    }
                }
                else
                {
                    await DisplayAlert("Ошибка", "Пожалуйста, выберите фильм.", "OK");
                }
            };

            BackgroundColor = Color.White;
            titleLabel.TextColor = Color.Black;
            quantityButton.BackgroundColor = Color.Red;
            quantityButton.TextColor = Color.White;
            costButton.BackgroundColor = Color.Red;
            costButton.TextColor = Color.White;
            listView.SeparatorColor = Color.Black;
            Content = new StackLayout
            {
                Children =
                {
                    titleLabel,
                    listView,
                    quantityButton,
                    costButton
                }
            };


            async void OnMovieSelected(object sender, SelectedItemChangedEventArgs e)
            {
                var selectedMovie = e.SelectedItem as Movie;
                if (selectedMovie != null)
                {
                    await DisplayAlert("Информация о фильме", $"Название: {selectedMovie.Title}\n" +
                                                             $"Киностудия: {selectedMovie.Studio}\n" +
                                                             $"Категория: {selectedMovie.Category}\n" +
                                                             $"Вместимость: {selectedMovie.Capacity}\n" +
                                                             $"Кинотеатр: {selectedMovie.Theater}\n" +
                                                             $"Зал: {selectedMovie.Hall}\n" +
                                                             $"Место: {selectedMovie.Seat}\n" +
                                                             $"Время: {selectedMovie.Time}\n" +
                                                             $"Дата: {selectedMovie.Date}\n" +
                                                             $"Режиссер: {selectedMovie.Director}\n" +
                                                              $"Год выпуска: {selectedMovie.Year}\n" +
                                                             $"Страна: {selectedMovie.Country}\n" +
                                                             $"Краткое содержание: {selectedMovie.Summary}\n" +
                                                              $"Цена билета: {selectedMovie.TicketPrice}\n"


                                                             , "OK");

                }
            }




        }
    }
}