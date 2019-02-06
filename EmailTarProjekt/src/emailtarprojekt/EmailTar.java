package emailtarprojekt;

public class EmailTar {

    private String email;

    public EmailTar(String email) throws Exception {

        if (email == "") {
            throw new Exception("EmailTar objektum üres email címmel nem jöhet létre!");
        }
        this.email = email;
    }

    public void ellenorzes() throws Exception {
        if (ellenorzesNincsKukacEmailCimben()) {
            throw new Exception("");
        }
    }

    private boolean ellenorzesNincsKukacEmailCimben() {
        for (char c : email.toCharArray()) {
            if (c == '@') {
                return false;
            }
        }
        return true;
    }
}
