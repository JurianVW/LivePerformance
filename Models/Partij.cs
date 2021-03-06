﻿namespace Models
{
    public class Partij
    {
        public int ID { get; private set; }
        public string Naam { get; private set; }
        public string NaamVolledig { get; private set; }
        public string Lijsttrekker { get; private set; }
        public int Stemmen { get; private set; }
        public decimal Percentage { get; private set; }
        public int Zetels { get; private set; }
        public Coalitie PartijCoalitie { get; private set; }

        public Partij(string naam, string naamVolledig, string lijsttrekker)
        {
            this.Naam = naam;
            this.NaamVolledig = naamVolledig;
            this.Lijsttrekker = lijsttrekker;
        }

        public Partij(string naam, string naamVolledig, string lijsttrekker, int stemmen, decimal percentage,
            int zetels)
        {
            this.Naam = naam;
            this.NaamVolledig = naamVolledig;
            this.Lijsttrekker = lijsttrekker;
            this.Stemmen = stemmen;
            this.Percentage = percentage;
            this.Zetels = zetels;
        }

        public void SetID(int id)
        {
            this.ID = id;
        }

        public void SetStemmen(int stemmen)
        {
            this.Stemmen = stemmen;
        }

        public void SetPercentage(decimal percentage)
        {
            this.Percentage = percentage;
        }

        public void SetZetels(int zetels)
        {
            this.Zetels = zetels;
        }

        public void voegToeAanCoalitie(Coalitie coalitie)
        {
            this.PartijCoalitie = coalitie;
        }

        public override string ToString()
        {
            return Naam;
        }

        public string ShowInfo()
        {
            return Naam + "  -  Zetels: " + Zetels + "  -  Lijsttrekker: " + Lijsttrekker;
        }

        public string ShowUitslagDetails()
        {
            return Naam + "  -  Stemmen: " + Stemmen + "  -  Percentage: " + Percentage + "%  -  Zetels:" + Zetels;
        }
    }
}