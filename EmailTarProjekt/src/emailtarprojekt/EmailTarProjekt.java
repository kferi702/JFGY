package emailtarprojekt;

public class EmailTarProjekt {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {

        String email = "Peti.vasvari.hu";

        try {
            EmailTar et = new EmailTar(email);
        } catch (Exception e) {
            System.out.println("Diák rossz e-mail cím miatt nem hozható létre!" + e.getMessage());
        }
    }
}
