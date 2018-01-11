using ManagerContact.Model.Classe;
using System;

namespace ManagerContact.Model.Service
{
    /// <summary>
    /// Gestion de contact
    /// </summary>
    ///
    public class ServiceContact
    {
        ///<summary>
        ///Fausse Données d' un contact
        ///</summary>
        public Contact FakeList()
        {
            bool randomGenre = GetRandomBooleanValue();

            if (randomGenre)
            {
                return new Contact { Nom = "Gripsou", Prenom = "Yvan", Age = 30, Genre = true };
            }
            else
            {
                return new Contact { Nom = "Scar", Prenom = "Tiffaine", Age = 40, Genre = false };
            }
        }

        ///<summary>
        ///obtention booléen aleatoirement
        ///</summary>
        private bool GetRandomBooleanValue()
        {
            Random rd = new Random(DateTime.Now.Millisecond);

            int rdValue = rd.Next(0, 100);

            if (rdValue > 50)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}