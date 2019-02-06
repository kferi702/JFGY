package emailtarprojekt;

/**
 * Email cím ellenőrző osztály
 */
public class EmailTar {

    /**
     * E-mail cím adattag
     */
    private String email;

    /**
     * Konstruktor
     *
     * @param email Input e-mail cím
     * @throws Exception
     */
    public EmailTar(String email) throws Exception {

        if (email == "") {
            throw new Exception("EmailTar objektum üres email címmel nem jöhet létre!");
        }
        this.email = email;
    }

    /**
     * Ellenőrzés vezérlő metódus
     *
     * @throws Exception
     */
    public void ellenorzes() throws Exception {

        if (ellenorzesNincsKukacEmailCimben()) {
            throw new Exception("Az email cím nem tartalmaz kukacot!");
        }

        if (ellenorzesNagybetuKukacElott()) {
            throw new Exception("Az email cím kukac előtt nagybetűt tartalmaz!");
        }

        if (ellenorzesKukacElottTobbPont()) {
            throw new Exception("Az email cím kukac előtt több pontot tartalmaz!");
        }
    }

    /**
     * Ellenőrző függvény, amely ellenőrzi nincs-e kukac karakter az input
     * e-mail címben
     *
     * @return Ha van logikai hamissal, ellenkező esetben logikai igazzal tér
     * vissza a függvény
     */
    private boolean ellenorzesNincsKukacEmailCimben() {
        for (char c : email.toCharArray()) {
            if (c == '@') {
                return false;
            }
        }
        return true;
    }

    /**
     * Ellenőrző függvény, amely ellenőrzi a kukac előtt van-e több pont
     * karakter
     *
     * @return Ha van logikai igazzal, ellenkező esetben logikai hamissal tér
     * vissza a függvény
     */
    private boolean ellenorzesKukacElottTobbPont() {

        String[] kukac = email.split("@");
        String kukacElott = kukac[0];

        // Üzemi kód
        
        return false;
    }

    /**
     * Ellenőrző függvény, amely ellenrőzi a kukac előtt van-e nagybetűs
     * karakter
     *
     * @return Ha van logikai igazzal, ellenkező esetben logikai hamissal tér
     * vissza a függvény
     */
    private boolean ellenorzesNagybetuKukacElott() {

        String[] kukac = email.split("@");
        String kukacElott = kukac[0];

        for (char c : kukacElott.toCharArray()) {
            if (Character.isUpperCase(c)) {
                return true;
            }
        }
        return false;
    }
}
