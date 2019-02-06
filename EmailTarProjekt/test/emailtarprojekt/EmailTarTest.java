package emailtarprojekt;

import org.junit.After;
import org.junit.AfterClass;
import org.junit.Before;
import org.junit.BeforeClass;
import org.junit.Test;
import static org.junit.Assert.*;

public class EmailTarTest {

    public EmailTarTest() {
    }

    @BeforeClass
    public static void setUpClass() {
    }

    @AfterClass
    public static void tearDownClass() {
    }

    @Before
    public void setUp() {
    }

    @After
    public void tearDown() {
    }

    @Test
    public void EmailTarKonstruktorUresEmailcim() {
        System.out.println("EmailTarKonstruktorUresEmailcim.");
        try {
            EmailTar et = new EmailTar("");
            fail("EmailTar konstruktor üres email címre nem dob kivételt!");
        } catch (Exception e) {
            if (e.getMessage() != "EmailTar objektum üres email címmel nem jöhet létre!") {
                fail("Email konstruktor üres emailcímre rossz szüvergű kivételt dob!");
            }
        }
    }

}
