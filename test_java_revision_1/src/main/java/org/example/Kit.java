package org.example;

import java.util.LinkedHashSet;
import java.util.Set;

public class Kit {
    private Set<Iblock> blocks =  new LinkedHashSet<Iblock>();
    private Set<String> motscles = new LinkedHashSet<String>();

    public Kit() throws IllegalBlockException {
        blocks.add(new Mur(3, 2, 2, true, false));
        blocks.add(new Mur(3, 2, 2, true, false));
        blocks.add(new Mur(2, 1, 2, false, false));
        blocks.add(new Mur(2, 1, 2, false, false));
        blocks.add(new Porte(1, 2, 2, true, false));

        //motscles.add("cabane");
        //motscles.add("muraille");
    }

    public void afficherKit() {
        System.out.println("Nombre de blocks dans le kit : " + blocks.size());
        System.out.println("Liste de mots clés : ");
        for (String motcle : motscles){
            System.out.println(motcle + " ");
        }
    }

    public Set<Iblock> getBlocks() {
        return blocks;
    }

    public void setBlocks(Set<Iblock> blocks) {
        this.blocks = blocks;
    }

    public Set<String> getMotscles() {
        return motscles;
    }

    public void setMotscles(Set<String> motscles) {
        this.motscles = motscles;
    }
}
