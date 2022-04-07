using System.Collections.Generic;

namespace _3_Itransition
{
    class GameLogic
    {
        public Dictionary<string, string> gameobjectRelations { get; }
        private string[] args;

        public GameLogic(string[] args)
        {
            this.args = args;
            gameobjectRelations = new Dictionary<string, string>(args.Length);
            for(int i =0; i<args.Length;i++)
                for(int j =0; j<args.Length;j++)
                    SetRelations(i, j);
        }

        public void SetRelations(int firstElement, int secondElement)
        {
            if (firstElement == secondElement)
                SetValueToRelations(firstElement, secondElement, "Draw");
            else if(IsWin(firstElement,secondElement))
                SetValueToRelations(firstElement, secondElement, "Win");
            else
                SetValueToRelations(firstElement, secondElement, "Lose");
        }

        public bool IsWin (int firstMove, int secondMove)
        {
            return (secondMove > firstMove && secondMove - firstMove <= args.Length / 2) 
                || (secondMove < firstMove && firstMove - secondMove > args.Length / 2);
        }

        private void SetValueToRelations(int firstMove, int secondMove, string relations)
        {
            gameobjectRelations[args[firstMove] + args[secondMove]] = relations;
        }
    }
}

