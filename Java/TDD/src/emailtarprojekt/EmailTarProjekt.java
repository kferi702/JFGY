/**
 * EmailTar projekt
 */
package emailtarprojekt;

/**
 * EmailTar projekt fő osztálya
 */
public class EmailTarProjekt {

    /**
     * Az alkalmazás belépési pontja
     *
     * @param args the command line arguments
     */
    public static void main(String[] args) {

        String email = "Peti.vasvari.hu";

        try {
            EmailTar et = new EmailTar(email);
            et.ellenorzes();
        } catch (EmailTarException e) {
            System.out.println("Diák rossz e-mail cím miatt nem hozható létre! " + e.getMessage());
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
    }
}
