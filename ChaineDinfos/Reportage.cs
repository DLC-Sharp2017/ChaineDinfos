namespace ChaineDinfos
{
    /// <summary>
    /// Classe définissant un reportage 
    /// </summary>
    class Reportage
    {
        /// <summary>
        /// Sujet du reportage
        /// </summary>
        public string sujetDuReportage { get; set; }

        internal Redacteur Redacteur
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}