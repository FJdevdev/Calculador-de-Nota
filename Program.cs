using System.Collections;


int provas = 5;

int [] sophiaSc = new int [] {90, 86, 87, 98, 100, 94, 90};
int [] andrewSc = new int [] {92, 89, 81, 96, 90, 89};
int [] emmaSc = new int [] {90, 85, 87, 98, 68, 89, 89, 89};
int [] loganSc = new int [] {90, 95, 87, 88, 96, 96};
int[] beckySc = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisSc = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericSc = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorSc = new int[] { 91, 91, 91, 91, 91, 91, 91 };   

string[] alunos = new string[]{"Sophia", "Andrew","Emma", "Logan", "Becky", "Chris", "Eric", "Gregor"};

int[] alunoSc = new int [10];

string notaLetra = "";

Console.WriteLine("Student\t\tGrade\n");

foreach(string aluno in alunos){

    string estudantes = aluno;

    if(estudantes == "Sophia"){
        alunoSc = sophiaSc;
    }
    else if (estudantes == "Andrew"){
        alunoSc = andrewSc;
    }
    else if (estudantes == "Emma"){
        alunoSc = emmaSc;
    }
    else if (estudantes == "Logan") {
        alunoSc = loganSc;
    }
    else if (estudantes == "Becky")
        alunoSc = beckySc;
    else if (estudantes == "Chris")
        alunoSc = chrisSc;
    else if(estudantes == "Eric")
        alunoSc = ericSc;
    else if(estudantes == "Gregor")
        alunoSc = gregorSc;
    else
        continue;

    int notas = 0;
    decimal grade = 0;

    int prova = 0;
    
    foreach(int sc in alunoSc){
        prova +=1;
        if (prova <= provas)
            notas+=sc;
        else
            notas += sc/10;
    }

    grade = (decimal)(notas)/provas;

    if(grade >=97)
        notaLetra = "A+";
    
    else if(grade>=93)
        notaLetra = "A";
    
    else if(grade>=90)
        notaLetra = "A-";
    
    else if(grade>=87)
        notaLetra = "B+";
    
    else if(grade>=83)
        notaLetra = "B";
    
    else if(grade>=80)
        notaLetra = "B-";
    
    else if(grade>=77)
        notaLetra = "C+";
    
    else if(grade>=73)
        notaLetra = "C";
    
    else if(grade>=70)
        notaLetra = "C-";
    
    else if(grade>=67)
        notaLetra = "D+";
    
    else if(grade>=63)
        notaLetra = "D";
    
    else if(grade>=60)
        notaLetra = "D-";
    
    else
        notaLetra = "F";


    
    Console.WriteLine($"{estudantes}\t\t{grade}\t{notaLetra}");   
    
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();