package emailtarprojekt;

public class EmailTar {

    private String email;

    public EmailTar(String email) throws Exception {

        if (email == "") {
            throw new Exception("");
        }
        this.email = email;
    }

}
