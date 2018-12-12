using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Globalization;

namespace wruszkaresuscytacja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random los = new Random();
/*            string[] I = { "Jutro, ", "Za pięć minut, ", "Za dwa lata, ", "Na następnym egzaminie, ", "W twoje najbliższe urodziny, ", "Na starość, ", "Na najbliższej imprezie, ", "Za tydzień, " };
            string[] II = { "zjesz żabę, ", "nic ci się nie uda, ", "poznasz swoją drugą połówkę, ", "zaczniesz tańczyć kankana na stole w obecności znajomych, ", "nie dstaniesz listu z Hogwartu, ", "upijesz się bezalkoholowym szampanem dla dzieci, ", "zostaniesz gwiazdą disko, ", "spotkasz Gandalfa, ", "porwą cię kosmici, ", "poznasz prawdziwego jednorożca, " };
            string[] III = { "i ", "potem ", "następnie ", "chwilę później ", "oraz ", "a także ", "a następnego dnia " };
            string[] IV = { "podejmiesz decyzję, która zmieni całe twoje życie, ", "zawalisz egzamin, ", "zmienisz płeć, ", "zjesz pizzę, ", "zrobisz sobie operację plastyczną, ", "zrobisz sobie tatuaż na kolanie, ", "zrobisz sobie tatuaż na brzuchu, ", "zrobisz sobie tatuaż na pięcie, ", "zrobisz sobie tatuaż na łokciu, ", "kupisz bezglutenowy ser bez laktozy, " };
            string[] V = { "więc ", "dlatego ", "co sprawi, że " };
            string[] VI = { "zaznasz szczęścia.", "rozpłaczesz się.", "zostaniesz klaunem.", "odkryjesz sens swojego życia.", "dostaniesz pracę w ministerstwie edukacji.", "zwątpisz w sens życia.", "rozpoczniesz pracę w Makdonaldzie.", "weźmiesz ślub dwa dni później.", "rozpoczniesz karierę babci klozetowej.", "obejrzysz nowy odcinek kucy z Bronksu.", "zamienisz się w wilkołaka." };
*/
            string [] I = {"Tomorrow, ", "In five minutes, ", "In two years, ", "At the next exam, ", "At your next birthday, ", "When you're old, ", "When you're sixty-four, ", "At the next party, ", "Next week, " };
            string [] II = {"you will eat a frog, ", "you will fail, ", "you will fall in love, ", "you will start to dance cancan on the table in the presence of your friends, ", "you won't get a letter from Hogwarts, ", "you will drink a non-alcoholic champagne for children, ", "you will become a disco star, ", "aliens will abduct you, ", "you will meet a real unicorn, "};
            string [] III = {"and ", "then ", "a moment later ", "also ", "the next day "};
            string [] IV = {"you will make a decision, that will change your whole life, ", "you won't pass your exam, ", "you will change gender, ", "you will eat pizza, ", "you will undergo plastic surgery, ", "you will get a tattoo on your knee , ", " you will get a tattoo on your belly, ", " you will get a tattoo on your heel, ", " you will get a tattoo on the elbow, ", "you will buy gluten-free cheese without lactose, "};
            string [] V = {"so ", "and because of that, "};
            string [] VI = {"you will feel happy.", "you will cry.", "you will become a clown.", "you will discover the meaning of your life.", "you will get a job in the ministry of education.", "you will doubt in the meaning of life.", " you will start working in McDonald's."," you will get married two days later."," you will start your toilet grandmother's career."," you will see a new episode of the Ponies from Bronx."," you will turn into a werewolf."};

            // Generate random indexes for pet names.
            int iIndex = los.Next(0, I.Length);
            int iiIndex = los.Next(0, II.Length);
            int iiiIndex = los.Next(0, III.Length);
            int ivIndex = los.Next(0, IV.Length);
            int vIndex = los.Next(0, V.Length);
            int viIndex = los.Next(0, VI.Length);

            string tekst = string.Concat(I[iIndex], II[iiIndex], III[iiiIndex], IV[ivIndex], V[vIndex], VI[viIndex]);

            Console.WriteLine(tekst);

            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Volume = 100;
            synth.Rate = -6;
            synth.SetOutputToDefaultAudioDevice();
            synth.Speak(tekst);
        }
    }
}
