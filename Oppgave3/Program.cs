class Oppgave3 {
    private static void Main() {
        List<Livsform> creatures = new List<Livsform>
        {
            new Menneske(), 
            new Hund(), 
            new Sau(), 
            new Apekatt(), 
            new Slange(), 
            new Edderkopp(), 
            new Frosk(),
            new Mygg(),
        };

        foreach (Livsform c in creatures) {
            c.LagLyd();
        }
    }
}

abstract class Livsform {
    abstract public void LagLyd();
}

abstract class Pattedyr : Livsform {}

abstract class Insekt : Livsform {}

abstract class Amfibie : Livsform {}

class Menneske : Pattedyr {
    public override void LagLyd() {
        Console.WriteLine("Hallo, Jeg elsker å begå Skattesvik");
    }
}
class Hund : Pattedyr {
    public override void LagLyd() {
        Console.WriteLine("Voff! Voff!");
    }
}
class Sau : Pattedyr {
    public override void LagLyd() {
        Console.WriteLine("BÆÆÆÆÆÆÆÆÆÆÆÆÆÆÆÆÆÆÆÆÆÆÆÆÆÆÆÆÆÆÆÆÆÆÆÆÆÆÆ!");
    }
}
class Apekatt : Pattedyr {
    public override void LagLyd() {
        Console.WriteLine("A E I O U Y Ø Æ Å");
    }
}
class Slange : Amfibie {
    public override void LagLyd() {
        Console.WriteLine("print('hallo verden')");
    }
}
class Edderkopp : Insekt {
    public override void LagLyd() {
        Console.WriteLine("I come from a long line of long legs.");
    }
}
class Frosk : Amfibie {
    public override void LagLyd() {
        Console.WriteLine("hippity hoppity");
    }
}
class Mygg : Insekt {
    public override void LagLyd() {
        Console.WriteLine("BZZZZ i am a useless waste of a creature. I am proof god dose not exist, or atleast dose not love his creation. the fact that such a useless creature can exist in this world, the only resemblance of a purpose being to spread and diseases to much more capable creatures. what a sad and meaningless existance. i am deeply asshamed to be a mosquito and i shamefully plead for forgiveness to anyone hearing my plead.");
    }
}
