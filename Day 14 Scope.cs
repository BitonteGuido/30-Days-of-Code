class Difference {
    private int[] elements;
    public int maximumDifference;
        public Difference(int[] elements)
    {
        this.elements = elements;
    }
    public void computeDifference()
    {
        int max = 0;
        int diferencia = 0;

        for (int i=0; i < elements.Length; i++){
            for(int j=0; j < elements.Length; j++){
                diferencia = elements[i] - elements[j];
                if(diferencia > max){
                    max = diferencia;
                }
            }
        maximumDifference = max;
        }
    }
}