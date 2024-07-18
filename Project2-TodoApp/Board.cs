using System.Collections.Generic;

namespace Project2_TodoApp
{
    public static class Board
    {
        private static List<Card> _todo = new List<Card>();
        private static List<Card> _inProgress = new List<Card>();
        private static List<Card> _done = new List<Card>();

        public static List<Card> Todo { get => _todo; set => _todo = value; }
        public static List<Card> InProgress { get => _inProgress; set => _inProgress = value; }
        public static List<Card> Done { get => _done; set => _done = value; }

    }
}