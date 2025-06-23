package org.example;

public class Rempart {

    private Iblock block;
    public Rempart(final Iblock Block){
        this.block = block;
    }
    //en utilisant l'interface Iblock au lieu de la classe Block, l'interface permet à l'objet de ne pas subir le couplage et donc si on modifie un
    // attribut propre à la classe Block, alors la classe Rempart n'aura pas à effectuer la modification liée au couplage de données
    //c'est une approche de découplement du fonctionnement d'une classe qui permet de générer une inversion de dépendance

    /*    L’injection de dépendances s’appuie sur l’utilisation des interfaces où :

        La classe Bloc va implémenter une interface IBloc.

        La classe Rempart va typer sa dépendance avec l’interface IBloc et non la classe Bloc.

        La classe Bloc ne sera pas instanciée au sein de la classe Rempart mais sera fournie à cette dernière via le constructeur (ou via un mutateur).

    Le résultat de l’injection de dépendances est que :

        L’interface IBloc est le contrat qui lie Rempart et Bloc.

        La classe Rempart n’a plus aucune référence vers la classe Bloc.

     */



}
