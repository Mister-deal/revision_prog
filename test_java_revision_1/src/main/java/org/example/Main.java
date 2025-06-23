package org.example;

import org.apache.logging.log4j.LogManager;
import org.apache.logging.log4j.Logger;

import java.util.*;

public class Main {
    private static Logger logger = LogManager.getLogger(Main.class);

    public static void main(String[] args) throws IllegalBlockException {
        System.out.println("Hello world!");
        System.out.println("test");

        int num = 5;
        num = 17;
        int number = 45;
        final int val = 150;
        String game = "game";

        String text = "value ";
        String text2 = "for an important ";
        String text3 = "data structure";

        System.out.println(text + text2 + text3);

        System.out.println(num * number);

        Byte value = -15;
        System.out.println(value * num);

        double decimal = 19.99;
        System.out.println(decimal + number);

        if (num >= 18){
            System.out.println("true");
        } else {
            System.out.println("false");
        }
        for(int i = 0; i < 15; i++){
            System.out.println(i);
        }

        System.out.println(val + " is the amount of time i had to play back that" + " " + game);

        String[] tableau = {"salut", "bonjour", "bonsoir", "au revoir"};
        System.out.println(tableau[1]);
        for (int j = 0; j < tableau.length; j++){
            System.out.println(tableau[j]);
        }

        test();
        affiche("salut toi!");
        System.out.println(calc(5, 6));
        afficher("maxime");
        Switch("soleil");
        list();

        Bloc unbloc = new Bloc("ceci est un bloc");
        unbloc.afficherDescription();

        Bloc unbloc2 = new Bloc("ceci est un second bloc");
        unbloc2.afficherDescription();

        Mur blockMur = new Mur(10, 5, 10, true, false);
        blockMur.afficherBloc();
        blockMur.afficherDescription();
        Iblock blockMur2 = new Mur(10, 10, 10, true, false);
        blockMur2.afficherDescription();

        Rempart monRempart = new Rempart(blockMur2);
        var terre = new Planete("terre", 40075.017, 510067420);
        System.out.println(terre);
        Porte porte = new Porte(10, 10, 5, true, false);
        porte.afficherDescription();
        porte.verrouiller();
        List<Integer> quantiteBlocksUtilises = new ArrayList<Integer>();
        quantiteBlocksUtilises.add(1);
        quantiteBlocksUtilises.add(3);
        quantiteBlocksUtilises.add(1);
        quantiteBlocksUtilises.remove(Integer.valueOf(1));

        for(Integer quantite: quantiteBlocksUtilises) {
            System.out.println(quantite);
        }

        Map<Block, Integer> quantiteBlock = new HashMap<Block, Integer>();
        quantiteBlock.put(new Mur(1,1,1, true, false), 4);
        quantiteBlock.put(new Porte(1,1,1, false, false), 4);

        Set<Block> cles = quantiteBlock.keySet();
        for(Block cle : cles){
            Integer valeur = quantiteBlock.get(cle);
            System.out.println(cle.getClass().getName() + " : " + valeur);
        }

        Kit kitDeDemarrage = new Kit();
        kitDeDemarrage.afficherKit();

        Kit kitExemple = new Kit();
        try {
            int resultat = kitExemple.getMotscles().size();
            System.out.println("Nombre de mots cles : " + resultat);
        } catch (NullPointerException e){
            System.out.println("Liste de mots clés indisponible");
        }

        try {
            Block b = new Mur(1,1,1,false, false);
            b.afficherDescription();
        }catch (IllegalArgumentException e){
            System.out.println("Valeurs pour construire le bloc invalides");
        }
    }

    public static void test(){
        System.out.println("test");
        System.out.println("test2");
        int value = 10;
        int num = 15;
        System.out.println(value + value + num);
    }
    public static void affiche(String texte){
        System.out.println(texte);
    }
    public static int calc(final int num1, final int num2){
        return num1 * num2;
    }
    public static void afficher(String texte) {
        System.out.println("bonjour " + texte);
    }

    public static void Switch(final String meteo){
        switch (meteo) {
            case "soleil" ->  System.out.println("beau temps");
            case "nuage" ->  System.out.println("couvert");
            case "pluie" ->  System.out.println("mauvais temps");
            default -> System.out.println("idk");
        }
    }

    public static void list (){
        List<String> nomsDesLangages = new ArrayList<>();
        nomsDesLangages.add("java");
        nomsDesLangages.add("php");
        nomsDesLangages.add("javascript");
        System.out.println(nomsDesLangages);
    }

}