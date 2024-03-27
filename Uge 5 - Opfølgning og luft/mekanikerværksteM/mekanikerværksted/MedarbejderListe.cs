using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mekanikerværksted
{
    internal class MedarbejderListe<TKey>
    {
        private Dictionary<TKey, IharAdresse> objListe = new Dictionary<TKey, IharAdresse>();

        public void AddElement(TKey key, Medarbejder element)
        {
            objListe.Add(key, element);
        }
        public void AddElement(TKey key, Firma element)
        {
            objListe.Add(key, element);
        }

        public IharAdresse GetElement(TKey key)
        {
            return objListe[key];
        }
        public int Size()
        {
            return objListe.Count;
        }

    }
}
