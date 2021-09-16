using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testi12333
    // lista työntekijöille
{
    class Users
    {
        public List<Users> _userList = new();

        public string _nimi;
        public int _palkka;
        public string _palkanrakenne;
        public string _palkkapäivä;
        public string _lisämaksut;

        public string Nimi { get; }
        public int Palkka { get; }
        public string Palkanrakenne { get; }

        public Users(string nimi, int palkka, string palkanrakenne, string palkkapäivä, string lisämaksut)
        {
            _nimi = nimi;
            _palkka = palkka;
            _palkanrakenne = palkanrakenne;
            _palkkapäivä = palkkapäivä;
            _lisämaksut = lisämaksut;
        }

        public Users(string nimi, int palkka, string palkanrakenne)
        {
            Nimi = nimi;
            Palkka = palkka;
            Palkanrakenne = palkanrakenne;
        }

        public string GetNimi()
        {
            return _nimi;
        }
        public void SetNimi(string nimi)
        {
            _nimi = nimi;
        }
        public int GetPalkka()
        {
            return _palkka;
        }
        public void SetPalkka(int palkka)
        {
            _palkka = palkka;
        }
        public string GetPalkanrakenne()
        {
            return _palkanrakenne;
        }
        public void SetPalkanrakenne(string palkanrakenne)
        {
            _palkanrakenne = palkanrakenne;
        }
    }
}
