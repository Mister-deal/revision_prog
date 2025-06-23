package org.example;

public class Bloc {
    private String description;

    public Bloc(String description) {
        this.description = description;
    }



    void afficherDescription() {
        System.out.println(this.description);
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }


}
