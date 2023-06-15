namespace Brovicon
{
    interface IStandard
    {
        public string[] GetAllowedFrameRates();
        public int GetWidth();
        public int GetHeight();
    }
}
