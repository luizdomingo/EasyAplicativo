namespace Easy.ApplicationDesk.Shared
{
    public class ColorsApp
    {

        List<CoresBase> colors;

        public ColorsApp()
        {
            colors = new List<CoresBase>();
        }

        private void CriarModelosCores()
        {
            colors.Add(new CoresBase("pdv", Color.Orange, Color.White));
        }


        public class CoresBase
        {
            public CoresBase(string? origem, Color cor_font, Color cor_backgroud)
            {
                this.Origem = origem;
                this.Cor_font = cor_font;
                this.Cor_backgroud = cor_backgroud;
            }

            public string? Origem { get; set; }
            public Color Cor_font { get; set; }
            public Color Cor_backgroud { get; set; }
        }
    }
}
