using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prakt6_2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        private decimal ticketPrice;
        private int selectedQuantity;
        public Page1()
        {
            InitializeComponent();
            var listView = new Movie
            {
                Title = "Человек-Паук 1 (2002)",
                Studio = "Marvel",
                Category = "Боевик/Фэнтези",
                Capacity = 125,
                Theater = "Аида",
                Hall = "Средний",
                Seat = "2",
                Time = "14:00",
                Date = System.DateTime.Today,
                Director = "Сэм Рэйми",
                Year = 2002,
                Country = "США",
                Summary = "Школьник-неудачник Питер Паркер становится супергероем.",
                TicketPrice = 150,
                ImagePath = "mov3.png"
            };
            int quantity = 5;
            decimal price = 1000;
            selectedQuantity = quantity;
            ticketPrice = price;

            var Page_main = new Main();
            var Page_3 = new Page4(listView);
            var Page_4 = new Page3(price, listView, quantity);

            /*Children.Add(Page_main);
            Children.Add(Page_3);
            Children.Add(Page_4);*/
        }
    }
}
