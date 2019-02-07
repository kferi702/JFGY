/**
 * EmailTar projekt
 */
package emailtarprojekt;

/**
 * EmailTar projekt saját kivétele
 */
public class EmailTarException extends Exception {

    /**
     * EmailTarException konsturkora
     *
     * @param message Kivétel üzenete
     */
    public EmailTarException(String message) {
        super(message);
    }

}
