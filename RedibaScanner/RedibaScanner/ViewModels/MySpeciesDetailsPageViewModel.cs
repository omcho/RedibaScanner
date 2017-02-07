﻿
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using RedibaScanner.Models;
namespace RedibaScanner.ViewModels
{
    public class MySpeciesDetailsPageViewModel : INotifyPropertyChanged
    {
        public MySpeciesDetails Species { get; set; }
        public List<string> Listaa { get; set; }
        public INavigation Navigation { get; set; }

        

        public event PropertyChangedEventHandler PropertyChanged;

        // configure the TapCommand with a method
        
        void OnTapped(object s)
        {
            var image = s as Models.CustomImage;
            if (image == null)
                return;
            ContentPage imagePage = new ContentPage();
            var myImage = new Xamarin.Forms.Image()
            {
                Source = FileImageSource.FromUri(
        new Uri(image.Url))
            };

            RelativeLayout layout = new RelativeLayout();

            layout.Children.Add(myImage,
                Constraint.Constant(0),
                Constraint.Constant(0),
                Constraint.RelativeToParent((parent) => { return parent.Width; }),
                Constraint.RelativeToParent((parent) => { return parent.Height; }));

            imagePage.Content = layout;
            imagePage.Title = image.ShortDesc;
            Navigation.PushAsync(imagePage);
        }


        public MySpeciesDetailsPageViewModel(MySpecies mySpecies)
        {
            
        Listaa = new List<string>() { "asss", "sddd" };
            //dobavljanje podataka
            Species = new MySpeciesDetails()
            {
                FullName = "Elephantus",
                DNKSequence = "AAAACCCTAAACCGGGGCCAAACCGGGGACCCTAAACCAAACCGG",
                BarCode = "AEF-456",
                QRCodeID = "ASD-334-1",
                AdditionalImages = new List<CustomImage>() {
                    new CustomImage() {Url ="http://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg",
                    ShortDesc ="Opis",
                    PictureTapCommand = new Command(OnTapped)
        },
                    new CustomImage() {Url ="http://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg",
                    ShortDesc ="Opis",
                    PictureTapCommand = new Command(OnTapped)
                    }
                },
                LocationSubmited = "Prašuma",
                Habitat = "Prašuma",
                Kingdom = "Životinja",
                Species = "Mislim da je Slon.",
                Notes = "Nađen je blizu vodopada.",
                HierarchyText = "Nivo 1, Nivo 2, Nivo 3",
                Information = "Slonovi su veliki sisari iz porodice Elephantidae (od lat. elefantus - slon) a spadaju u red Proboscidea (surlaša). Obično se razlikuju dva roda slonova afrički slon (Loxodonta africana) i azijski slon (Elephas maximus), mada postoje neki dokazi da su afrički savanski slon i afrički šumski slon dvije različite vrste (L. africana i L. cyclotis, respektivno). Slonovi su rašireni širom podsaharske Afrike i južne i jugoistočne Azije. Porodica Elephantidae je jedina preživjela porodica iz reda surlaša; druge, danas izumrle vrste iz ovog roda su bile mamuti i mastodonti. Mužjak afričkog slona je najveća kopnena životinja i može doseći visinu od 4 m i težinu od 7 tona. Svi slonovi imaju nekoliko karakterističnih osobina, od koji su najuočljiviji dugo debelo rilo zvano surla, kojim slonovi uzimaju vodu, dišu i dohvataju hranu i predmete. Njihovi sjekutići su narasli u kljove koje mogu služiti kao oružje protiv grabežljivaca ili kao alat za pomjeranje objekata ili kopanje. Svojim velikim ušima mogu mahati čime pomažu u snižavanju temperature tijela. Afrički slonovi imaju veće uši i konkavna leđa dok azijski slonovi imaju manje uši i konveksna ili ravna leđa.",
                Images = new List<Models.CustomImage>() {
                    new CustomImage() {Url ="http://likovna-kultura.ufzg.unizg.hr/konstruktor/radovi/slon.africki.jpg",
                    ShortDesc ="Opis",
                    PictureTapCommand = new Command(OnTapped)
                    },
                    new CustomImage() {Url ="http://www.vijesti.rtl.hr/novosti/svijet/1966787/tragedija-na-odmoru-turista-iz-italije-u-keniji-ubio-slon/",
                    ShortDesc ="Opis",
                    PictureTapCommand = new Command(OnTapped)
                    }
                },
                LocationText = "Slonovi se mogu pronaći u - Africi \n -Aziji",
                RecordsAvailableText = "65 dostupnih primjeraka",
                PercentPublicText = "81% je javno",
                SpeciesSearchInfo = new SpeciesSearchInfo()
                {
                    Name = "Baboon Baboonos",
                    Location = "Slonovi se mogu pronaći u - Africi \n -Aziji",
                    Hierarchy = "Arthropoda, Malacostraca, Isopoda, Philosciidae, Philoscia, Philoscia muscorum",
                    RecordsAvailableText = "Dostupno bilješki: 1233",
                    PercentPublicText = "Javno: 55%",
                    SpeciesCollectedText = "Sakupljeno vrsta: 1222",
                    Description = "Slonovi su veliki sisari iz porodice Elephantidae (od lat. elefantus - slon) a spadaju u red Proboscidea (surlaša). Obično se razlikuju dva roda slonova afrički slon (Loxodonta africana) i azijski slon (Elephas maximus), mada postoje neki dokazi da su afrički savanski slon i afrički šumski slon dvije različite vrste (L. africana i L. cyclotis, respektivno). Slonovi su rašireni širom podsaharske Afrike i južne i jugoistočne Azije. Porodica Elephantidae je jedina preživjela porodica iz reda surlaša; druge, danas izumrle vrste iz ovog roda su bile mamuti i mastodonti. Mužjak afričkog slona je najveća kopnena životinja i može doseći visinu od 4 m i težinu od 7 tona. Svi slonovi imaju nekoliko karakterističnih osobina, od koji su najuočljiviji dugo debelo rilo zvano surla, kojim slonovi uzimaju vodu, dišu i dohvataju hranu i predmete. Njihovi sjekutići su narasli u kljove koje mogu služiti kao oružje protiv grabežljivaca ili kao alat za pomjeranje objekata ili kopanje. Svojim velikim ušima mogu mahati čime pomažu u snižavanju temperature tijela. Afrički slonovi imaju veće uši i konkavna leđa dok azijski slonovi imaju manje uši i konveksna ili ravna leđa.",
                    Image = "http://likovna-kultura.ufzg.unizg.hr/konstruktor/radovi/slon.africki.jpg",
                    Images = new List<CustomImage>() { new CustomImage() {

                            Url="https://upload.wikimedia.org/wikipedia/commons/2/22/Afrikanischer_Elefant,_Miami.jpg", ShortDesc="Joj"
                         },
                            new CustomImage() {

                            Url="http://likovna-kultura.ufzg.unizg.hr/konstruktor/radovi/slon.africki.jpg", ShortDesc="Joj2"
                            }
                    }
                }
                
            };


        }
    }
}
