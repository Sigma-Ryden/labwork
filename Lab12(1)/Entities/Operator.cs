using Lab_12.Interfaces;

namespace Lab_12.Entities
{
    public class Operator
    {
        public double PrevOperand;
        public IOperation CurrentOperation;
        
        public double? GetResult(IOperation operation, double newOperand)
        {
            if (CurrentOperation == null)
            {
                CurrentOperation = operation;
                PrevOperand = newOperand;
                return null;
            }
            
            double? result = CurrentOperation.Operate(PrevOperand, newOperand);
            PrevOperand = newOperand;
            
            if (operation == null)
            {
                Reset();
            }
            
            return result;
        }

        public void Reset()
        {
            CurrentOperation = null;
            PrevOperand = 0;
        }
    }
}