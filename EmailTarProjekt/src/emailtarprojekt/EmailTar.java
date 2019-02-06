package emailtarprojekt;

public class EmailTar {

    private String email;

    public EmailTar(String email) throws Exception {

        if (email == "EmailTar objektum üres email címmel nem jöhet létre!") {
            throw new Exception("");
        }
        this.email = email;
    }

}
