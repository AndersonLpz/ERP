namespace XRM.Domain._0_Entities._01_Cadastro
{
    /*
     * Tabela de cadastro Cliente x Cedente
     */
    public class TBCADCLIECED
    {
        public int TBCADCLIECED_NS { get; set; }

        public int TBCADCEDENTE_NS { get; set; }

        public virtual TBCADCEDENTE TBCADCEDENTE { get; set; }

        public int TBCLIENTEXXX_NS { get; set; }

        public virtual TBCADCLIENTE TBCADCLIENTE { get; set; }

    }
}
