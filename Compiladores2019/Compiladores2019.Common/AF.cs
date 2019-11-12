using System.Collections.Generic;

namespace Compiladores2019.Common
{

    // Clase donde se capturan los datos básicos para los automátas finitos
    public static class AF
    {
        public static string[] SymbolsIN { get; set; }
        public static string[] States{ get; set; }
        public static string[] StatesBegin { get; set; }
        public static string[] Acceptations { get; set; }
        public static List<ItemTransition> TableTransitions { get; set; }
    }
}
