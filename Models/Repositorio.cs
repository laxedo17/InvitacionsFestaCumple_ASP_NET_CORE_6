namespace InvitacionsFesta.Models
{
    public static class Repositorio
    {
        private static List<InvitacionResposta> respostas = new();

        public static IEnumerable<InvitacionResposta> Respostas => respostas;
        //equivalente a
        /*
        public static IEnumerable<InvitacionResposta> Respostas
        {
            get
            {
                return respostas;
            }
        }
        */

        public static void AddResposta(InvitacionResposta resposta)
        {
            Console.WriteLine(resposta);
            respostas.Add(resposta);
        }
    }
}