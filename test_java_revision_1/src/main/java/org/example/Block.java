package org.example;

import org.apache.logging.log4j.LogManager;
import org.apache.logging.log4j.Logger;

public abstract class Block implements Iblock {
    private static Logger logger = LogManager.getLogger(Block.class);
    protected int longueur;
    protected int largeur;
    protected int hauteur;
    protected Couleur couleur;

    public Block(int longueur, int largeur, int hauteur, final boolean test) throws IllegalBlockException {
        if(longueur < MIN_LONGUEUR || largeur < MIN_LARGEUR || hauteur < MIN_HAUTEUR){
            logger.error("les valeurs minimales pour longueur, largeur et hauteur n'ont pas été respectées");
            throw new IllegalBlockException();
        }
        this.longueur = longueur;
        this.largeur = largeur;
        this.hauteur = hauteur;

        logger.info("un bloc de type " + this.getClass().getSimpleName() + " a été construit");
    }

    public int getLongueur() {
        return longueur;
    }

    public int getLargeur() {
        return largeur;
    }

    public int getHauteur() {
        return hauteur;
    }

    public void setCouleur(Couleur couleur) {
        this.couleur = couleur;
    }
}
