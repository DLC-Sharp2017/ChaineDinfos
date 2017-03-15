﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaineDinfos
{
    sealed class Envoye : Journaliste
    {
        public Envoye(string prenom) : base(prenom)
        {

        }

        public Envoye (int jourDeLaMission = 10)
        {
            Console.WriteLine("Nombres de jours de la mission : {0}", jourDeLaMission);
        }

        /// <summary>
        /// Constructeur pour ilustrer un appel par étiquette
        /// </summary>
        /// <param name="departementDeLaMission"></param>
        /// <param name="jourDeLaMission"></param>

        public Envoye (string departementDeLaMission, int jourDeLaMission = 10)
        {
            Console.WriteLine("Département de la mission : {0}", departementDeLaMission);
            Console.WriteLine("Nombres de jours de la mission : {0}", jourDeLaMission);
        }

        public Envoye (Reportage mission)
        {

        }
        /// <summary>
        /// Zone d'affectation
        /// </summary>
        public string LieuDAffectation { get; set; }

        /// <summary>
        /// Décrit le poste de l'envoyé
        /// </summary>
        public Poste PosteDeLEnvoye { get; set; }

        /// <summary>
        /// Filme un Reportage
        /// </summary>
        /// <returns>Reportage</returns>
        public Reportage Filmer()
        {
            Console.WriteLine("Je filme pour {0}", chaineTV);
            Reportage reportage = new Reportage();
            reportage.sujetDuReportage = "Final de pétanque 2017";
            return reportage;
        }
        /// <summary>
        /// Rédige un reportage.
        /// </summary>
        /// <param name="texteduSujet"></param>
        /// <param name="dateDuSujet"></param>
        /// <param name="titreDuSujet"></param>
        /// <returns>Reportage</returns>
        public override Reportage Rediger(string texteduSujet, DateTime dateDuSujet, string titreDuSujet)
        {
            Console.WriteLine("je rédige un reportage");
            Reportage reportage = new Reportage();
            reportage.sujetDuReportage = "un sujet";
            return reportage;
        }


        
    }
}
