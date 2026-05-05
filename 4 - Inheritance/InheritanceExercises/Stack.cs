namespace InheritanceExercises
{
    public class Stack
    {
        List<object> _stackObjects = new List<object>();
        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException("Stack cannot store a null reference.");
            }
            else
            {
                _stackObjects.Add(obj);
            }
        }

        public object Pop()
        {
            if (_stackObjects.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty!");
            }
            else
            {
                var obj = _stackObjects[_stackObjects.Count - 1];
                _stackObjects.RemoveAt(_stackObjects.Count - 1);
                return obj;
            }
        }

        public void Clear()
        {
            _stackObjects.Clear();
        }
    }
}
