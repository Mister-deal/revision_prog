package org.example;

import org.apache.logging.log4j.LogManager;
import org.apache.logging.log4j.Logger;

public class Porte extends Block{
    private static Logger logger = LogManager.getLogger(Porte.class);

    private boolean verrou;

    public Porte(int longueur, int largeur, int hauteur, boolean verrou, boolean test) throws IllegalBlockException {
        super(longueur, largeur, hauteur, test);
        this.verrou = verrou;
        this.couleur = Couleur.BLEU;
    }

    public boolean estVerrouillee() {
        return verrou;
    }

    public void verrouiller() {
        if(verrou){
            logger.error("la porte ne peut pas être vérouillée car c'est déjà le cas");
        } else {
            verrou = true;
        }
    }

    @Override
    public void afficherDescription() {
        System.out.println("je suis une porte " + couleur);
    }
}
