using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CinemaApp
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Tickets = GetTickets();
            this.BindingContext = this;
        }

        public ObservableCollection<Ticket> Tickets { get; set; }
        public Ticket SelectedTicket { get; set; }

        private ObservableCollection<Ticket> GetTickets()
        {
            return new ObservableCollection<Ticket>
            {
                new Ticket { MovieTitle = "House of Gucci", Image = "HouseOfGucci.jpg", ShowingDate = DateTime.Now.AddDays(15), Seats = new int[] { 61, 62, 63 } },
                new Ticket { MovieTitle = "Spider-man: No way home", Image = "spiderman.jpg", ShowingDate = DateTime.Now.AddDays(22), Seats = new int[] { 111, 112 } },
                new Ticket { MovieTitle = "The Hating Game", Image = "hatinggame.jpg", ShowingDate = DateTime.Now.AddDays(25), Seats = new int[] { 12, 25, 35 } },
                new Ticket { MovieTitle = "The King's Man", Image = "thekingsman.jpg", ShowingDate = DateTime.Now.AddDays(28), Seats = new int[] { 99 } },
                new Ticket { MovieTitle = "The Matrix Resurrections", Image = "Matrix.jpg", ShowingDate = DateTime.Now.AddDays(20), Seats = new int[] { 15,16 } },
                new Ticket { MovieTitle = "Spencer", Image = "Spencer.jpg", ShowingDate = DateTime.Now.AddDays(18), Seats = new int[] { 26,27 } },
                new Ticket { MovieTitle = "The 355", Image = "The.jpg", ShowingDate = DateTime.Now.AddDays(27), Seats = new int[] { 2,3 } }
            };
        }

        private void TicketSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection != null)
            {
                this.Navigation.PushAsync(new SeatsPage(SelectedTicket));
            }
        }
    }

    public class Ticket
    {
        public string MovieTitle { get; set; }
        public DateTime ShowingDate { get; set; }
        public string Image { get; set; }
        public int[] Seats { get; set; }
    }
}
