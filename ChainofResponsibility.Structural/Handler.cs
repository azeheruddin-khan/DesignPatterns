namespace ChainofResponsibility.Structural
{
    public abstract class Handler
    {
        protected Handler successor;
        public void SetSuccessor(Handler handler)
        {
            this.successor = handler;
        }

        public abstract void HandleRequest(int request);

    }
}
