package org.example;

public class Mur extends Block{

    private boolean porteur;

    public Mur(int longueur, int largeur, int hauteur, boolean porteur, boolean test) throws IllegalBlockException{
        super(longueur, largeur, hauteur, test);
        this.porteur = porteur;
        this.couleur = Couleur.GRIS;
    }

    public void afficherBloc() {
        System.out.println(
                super.hauteur + " " +
                super.largeur + " " +
                        super.longueur + " " +
                        this.porteur
        );
    }
    @Override
    public void afficherDescription() {
        System.out.println("je suis un mur " + couleur);
    }

    public boolean estTraversable() {
        return !porteur;
    }
}
