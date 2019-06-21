import java.util.ArrayList;                                             //importujemy obsluge list
import java.util.Scanner;                                               //importujemy mozliwosc wpisywania danych do programu

public class Main {                                                     //glowna funkcja programu
    public static void main(String[] args) {
        Scanner kb = new Scanner(System.in);                            //tworzymy obiekt kb aby moc wpisywac dane
        int idCount = 1;                                                //idcount pomaga nam przypisac odpowiedni numer id do osoby ktora towrzymy
        ArrayList<Persons> peopleAr = new ArrayList<Persons>();         //utworzenie listy


        while(true) {                                                   //wyswietla menu w petli nieskonczonej
            System.out.println("");
            System.out.println("Wcisnij liczbe odpowiadającą twojemu wyborowi:");
            System.out.println("1. Dodaj nową osobę");
            System.out.println("2. Wyswietl wszystkich");
            System.out.println("3. Usuwanie");
            System.out.println("4. Wyjdz.");

            int key = kb.nextInt();

            switch (key) {
                case 1:

                    System.out.println("Wpisz imie i nazwisko :) Jak chcesz wyjsc do menu wpisz \"koniec\" ");

                    while(true) {
                        Persons newPeople = new Persons();                   //tworzy obiekt klasy person (nowego zclowieka)
                        String name;
                        String surname;

                        System.out.println("Wpisz imie: ");
                        name = kb.next();                                    //funkcja skanera dzieki ktorej mozemy przypisac wartosc do "name"
                        if (!name.equals("koniec"))                          //jezeli imie = koniec, nastapi wyrzucenie do menu
                            newPeople.name = name;                           //przypisanie imienia zmiennej "name" do naszego nowego czlowieka "newPeople.name"
                        else break;

                        System.out.println("Wpisz nazwisko: ");
                        surname = kb.next();
                        if (!name.equals("koniec")) {
                            newPeople.surname = surname;
                        }
                        else break;

                        newPeople.id = idCount;
                        peopleAr.add(newPeople);                            //nowy obiekt czlowieka wskakuje do peopleAr
                        idCount = idCount + 1;
                    }
                    break;

                case 2:

                    peopleAr.stream().map(o -> o.id  + " " + o.name + " " + o.surname).forEach(System.out::println);                //magia z internetu, znalazlem jak szukalem jak wyswietlic ArrayList
                    break;

                case 3:

                    peopleAr.stream().map(o -> o.id  + " " + o.name + " " + o.surname).forEach(System.out::println);
                    System.out.println("kogo chcesz usunac? Wpisz odpowiednie id: ");
                    peopleAr.remove(kb.nextInt() - 1);                                                                        //usuwa obiekt o danym indeksie, dlatego tez mamy -1

                    peopleAr.stream().map(o -> o.id  + " " + o.name + " " + o.surname).forEach(System.out::println);
                    break;

                case 4:
                    System.exit(0);                             //wychodzi z programu

            }

        }
    }
}
