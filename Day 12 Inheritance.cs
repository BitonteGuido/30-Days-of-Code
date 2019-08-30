class Person{
    protected string firstName;
    protected string lastName;
    protected int id;
    
    public Person(){}
    public Person(string firstName, string lastName, int identification){
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
    }
    public void printPerson(){
        Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id); 
    }
}
class Student : Person{
    private int[] testScores;  
    
    public Student(string firstName, string lastName, int identification, int[] tS):base(firstName, lastName, identification){
        testScores = tS;
    }

    public char Calculate(){
        int sum = 0;
        for (int i = 0; i < testScores.Length; i++){
            sum += testScores[i];
        }
        int n=testScores.Length;
        int prom = sum/n;
        if(prom>=90 && prom<=100){
            return('O');
        }
        else if(prom>=80 && prom<=90){
            return('E');
        }
        else if(prom>=70 && prom<=80){
            return('A');
        }
        else if(prom>=55 && prom<=70){
            return('P');
        }
        else if(prom>=40 && prom<=55){
            return('D');
        }
        else if(prom<40){
            return('T');
        }
        return 'Z';           
    }
}