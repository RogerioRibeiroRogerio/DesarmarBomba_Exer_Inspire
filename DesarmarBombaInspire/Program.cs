using System; 
namespace DesarmarBombaInspire
{
    class Program
    {
        public static void Main(string[] args)
        {
            CaboEletrico1();  
        }
        // CRIAÇÃO DO MENU1 
        static void CaboEletrico1()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("ESCOLHA A COR DO CABO ELETRICO PARA DESATIVAR A BOMBA");
            Console.WriteLine("REGRAS - Se cortares um fio branco não podes cortar um fio branco ou preto.");
            Console.WriteLine("       - Se cortares um fio vermelho tens de cortar um fio verde.");
            Console.WriteLine("       - Se cortares um fio preto não é permitido cortar um fio branco, verde ou laranja.");
            Console.WriteLine("       - Se cortares um fio laranja tu deves cortar um fio vermelho ou preto.");
            Console.WriteLine("       - Se cortares um fio verde tens de cortar um fio laranja ou branco.");
            Console.WriteLine("       - Se cortares um fio roxo não podes cortar um fio roxo, verde, laranja ou branco.");
            Console.WriteLine("       - Caso não sejam cumpridas estas regras a bomba explode.");
            Console.WriteLine("");
            //VIEWS DO MENU1 
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("BRANCO");
            Console.ResetColor();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("VERMELHO");
            Console.ResetColor();
            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("PRETO");
            Console.ResetColor();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("LARANJA");
            Console.ResetColor();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("VERDE");
            Console.ResetColor();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("ROXO");
            Console.ResetColor();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Escreva somente o nome da cor do cabo que quer cortar e pressione a tecla 'ENTER'");
            Console.ResetColor();
            // string que recebe o que for inserido pelo utilizador
            string proxcabo;
            proxcabo = Console.ReadLine();
            switch (proxcabo)
            {
                case "Branco"or"BRANCO"or"branco":
                    CaboEletrico2();
                    break;
                case "Vermelho"or"VERMELHO"or"vermelho":
                    BombaExplode();
                    break;
                case "Preto"or"PRETO"or"preto":
                    BombaExplode();
                    break;
                case "Laranja"or"LARANJA"or"laranja":
                    BombaExplode();
                    break;
                case "Verde"or"VERDE"or"verde":
                    BombaExplode();
                    break;
                case "Roxo"or"ROXO"or"roxo":
                    BombaExplode();
                    break;
            }
        }
        // CRIAÇÃO DO MENU2
        static void CaboEletrico2()
        {
            Console.Beep();
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("PARABÉNS, ACERTOU NA PRIMEIRA COR, FALTA AINDA ADIVINHAR MAIS TRÊS CORES!");
            Console.WriteLine("");
            Console.WriteLine("REGRAS - Se cortares um fio branco não podes cortar um fio branco ou preto.");
            Console.WriteLine("       - Se cortares um fio vermelho tens de cortar um fio verde.");
            Console.WriteLine("       - Se cortares um fio preto não é permitido cortar um fio branco, verde ou laranja.");
            Console.WriteLine("       - Se cortares um fio laranja tu deves cortar um fio vermelho ou preto.");
            Console.WriteLine("       - Se cortares um fio verde tens de cortar um fio laranja ou branco.");
            Console.WriteLine("       - Se cortares um fio roxo não podes cortar um fio roxo, verde, laranja ou branco.");
            Console.WriteLine("       - Caso não sejam cumpridas estas regras a bomba explode.");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("BRANCO");
            Console.ResetColor();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("VERMELHO");
            Console.ResetColor();
            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("PRETO");
            Console.ResetColor();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("LARANJA");
            Console.ResetColor();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("VERDE");
            Console.ResetColor();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("ROXO");
            Console.ResetColor();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Insira o nome da próxima cor para continuar a desactivar a bomba.");
            Console.ResetColor();
            string proxcabo;
            proxcabo = Console.ReadLine();
            switch (proxcabo)
            {
                case "Branco" or "BRANCO" or "branco":
                    BombaExplode();
                    break;
                case "Vermelho" or "VERMELHO" or "vermelho":
                    CaboEletrico3();
                    break;
                case "Preto" or "PRETO" or "preto":
                    BombaExplode();
                    break;
                case "Laranja" or "LARANJA" or "laranja":
                    BombaExplode();
                    break;
                case "Verde" or "VERDE" or "verde":
                    BombaExplode();
                    break;
                case "Roxo" or "ROXO" or "roxo":
                    BombaExplode();
                    break;
            }
        }
        // CRIAÇÃO DO MENU3
        static void CaboEletrico3()
        {
            Console.Beep();
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("PARABÉNS, ACERTOU NA SEGUNDA COR, FALTA ADIVINHAR MAIS DUAS CORES!");
            Console.WriteLine("");
            Console.WriteLine("ESCOLHA A COR SEGUINTE PARA DESATIVAR A BOMBA");
            Console.WriteLine("");
            Console.WriteLine("REGRAS - Se cortares um fio branco não podes cortar um fio branco ou preto.");
            Console.WriteLine("       - Se cortares um fio vermelho tens de cortar um fio verde.");
            Console.WriteLine("       - Se cortares um fio preto não é permitido cortar um fio branco, verde ou laranja.");
            Console.WriteLine("       - Se cortares um fio laranja tu deves cortar um fio vermelho ou preto.");
            Console.WriteLine("       - Se cortares um fio verde tens de cortar um fio laranja ou branco.");
            Console.WriteLine("       - Se cortares um fio roxo não podes cortar um fio roxo, verde, laranja ou branco.");
            Console.WriteLine("       - Caso não sejam cumpridas estas regras a bomba explode.");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("BRANCO");
            Console.ResetColor();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("VERMELHO");
            Console.ResetColor();
            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("PRETO");
            Console.ResetColor();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("LARANJA");
            Console.ResetColor();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("VERDE");
            Console.ResetColor();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("ROXO");
            Console.ResetColor();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Insira o nome da próxima cor para continuar a desactivar a bomba.");
            Console.ResetColor();
            string proxcabo;
            proxcabo = Console.ReadLine();
            switch (proxcabo)
            {
                case "Branco" or "BRANCO" or "branco":
                    BombaExplode();
                    break;
                case "Vermelho" or "VERMELHO" or "vermelho":
                    BombaExplode();
                    break;
                case "Preto" or "PRETO" or "preto":
                    BombaExplode();
                    break;
                case "Laranja" or "LARANJA" or "laranja":
                    BombaExplode();
                    break;
                case "Verde" or "VERDE" or "verde":
                    CaboEletrico4();
                    break;
                case "Roxo" or "ROXO" or "roxo":
                    BombaExplode();
                    break;
            }
        }
        // CRIAÇÃO DO MENU3
        static void CaboEletrico4()
        {
            Console.Beep();
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("PARABÉNS, ACERTOU NA TERCEIRA COR, FALTA ADIVINHAR MAIS UMA COR!");
            Console.WriteLine("");
            Console.WriteLine("ESCOLHA A COR SEGUINTE PARA DESATIVAR A BOMBA");
            Console.WriteLine("");
            Console.WriteLine("REGRAS - Se cortares um fio branco não podes cortar um fio branco ou preto.");
            Console.WriteLine("       - Se cortares um fio vermelho tens de cortar um fio verde.");
            Console.WriteLine("       - Se cortares um fio preto não é permitido cortar um fio branco, verde ou laranja.");
            Console.WriteLine("       - Se cortares um fio laranja tu deves cortar um fio vermelho ou preto.");
            Console.WriteLine("       - Se cortares um fio verde tens de cortar um fio laranja ou branco.");
            Console.WriteLine("       - Se cortares um fio roxo não podes cortar um fio roxo, verde, laranja ou branco.");
            Console.WriteLine("       - Caso não sejam cumpridas estas regras a bomba explode.");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("BRANCO");
            Console.ResetColor();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("VERMELHO");
            Console.ResetColor();
            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("PRETO");
            Console.ResetColor();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("LARANJA");
            Console.ResetColor();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("VERDE");
            Console.ResetColor();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("ROXO");
            Console.ResetColor();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Insira o nome da ultima cor para desactivar a bomba.");
            Console.ResetColor();
            string proxcabo;
            proxcabo = Console.ReadLine();
            switch (proxcabo)
            {
                case "Branco" or "BRANCO" or "branco":
                    BombaDesarmada();
                    break;
                case "Vermelho" or "VERMELHO" or "vermelho":
                    BombaExplode();
                    break;
                case "Preto" or "PRETO" or "preto":
                    BombaExplode();
                    break;
                case "Laranja" or "LARANJA" or "laranja":
                    BombaExplode();
                    break;
                case "Verde" or "VERDE" or "verde":
                    BombaExplode();
                    break;
                case "Roxo" or "ROXO" or "roxo":
                    BombaExplode();
                    break;
            }
        }
        // CRIAÇÃO DO MENU BOMBA EXPLODIU
        static void BombaExplode()
        {
            Console.Clear();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("██████   ██████  ███    ███ ██████   █████      ███████ ██   ██ ██████  ██       ██████  ██████  ██ ██    ██ ");
            Console.WriteLine("██   ██ ██    ██ ████  ████ ██   ██ ██   ██     ██       ██ ██  ██   ██ ██      ██    ██ ██   ██ ██ ██    ██ ");
            Console.WriteLine("██████  ██    ██ ██ ████ ██ ██████  ███████     █████     ███   ██████  ██      ██    ██ ██   ██ ██ ██    ██ ");
            Console.WriteLine("██   ██ ██    ██ ██  ██  ██ ██   ██ ██   ██     ██       ██ ██  ██      ██      ██    ██ ██   ██ ██ ██    ██ ");
            Console.WriteLine("██████   ██████  ██      ██ ██████  ██   ██     ███████ ██   ██ ██      ███████  ██████  ██████  ██  ██████  ");
            Console.Beep();
        }
        // CRIAÇÃO DO MENU BOMBA OFF
        static void BombaDesarmada()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("██████   ██████  ███    ███ ██████   █████       ██████  ███████ ███████");
            Console.WriteLine("██   ██ ██    ██ ████  ████ ██   ██ ██   ██     ██    ██ ██      ██     ");
            Console.WriteLine("██████  ██    ██ ██ ████ ██ ██████  ███████     ██    ██ █████   █████  ");
            Console.WriteLine("██   ██ ██    ██ ██  ██  ██ ██   ██ ██   ██     ██    ██ ██      ██     ");
            Console.WriteLine("██████   ██████  ██      ██ ██████  ██   ██      ██████  ██      ██     ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("MUITOS PARABÉNS, VOCÊ É UM GENIO E SALVOU PESSOAS");
        }

    }
}
