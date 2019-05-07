namespace PDGT.Models
{
    public class Exercise
    {
        public string Name { get; set; }
        public Guide Guide { get; set; }
        public int Weight { get; set; }
        public int Repetitions { get; set; }
        public int Sets { get; set; }
    }
}