package emailtarprojekt;

import java.util.logging.Level;
import java.util.logging.Logger;
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

    @Test
    public void testEllenorzesNincsKukac() {
        System.out.println("testEllenorzesNincsKukac");
        try {
            EmailTar instance = new EmailTar("Peti.vasvari.hu");
            instance.ellenorzes();
            fail("Az ellenőrzés kukac nélküli e-mail címre az ellenőrzés nem dob kivételt!");
        } catch (Exception e) {
            if (e.getMessage() != "Az email cím nem tartalmaz kukacot!") {
                fail("Kukac nélküli email cím esetén az ellenőrzés rossz szövegű kivételt dob!");
            }
        }
    }

    @Test
    public void testEllenorzesNagybetuKukacElott() {
        System.out.println("testEllenorzesNagybetuKukacElott");
        try {
            EmailTar instance = new EmailTar("Peti@vasvari.hu");
            instance.ellenorzes();
            fail("Az ellenőrzés kukac előtt nagybetű esetén nem dob kivételt!");
        } catch (Exception e) {
            if (e.getMessage() != "Az email cím kukac előtt nagybetűt tartalmaz!") {
                fail("Kukac előtt nagybetű és az ellenőrzés rossz szövegű kivételt dob!");
            }
        }
    }

    @Test
    public void testEllenorzesNagybetuKisbetuEsTobbPontKukacElott() {
        System.out.println("testEllenorzesNagybetuKisbetuEsTobbPontKukacElott");
        try {
            EmailTar instance = new EmailTar("Peti.p.p@vasvari.hu");
            instance.ellenorzes();
            fail("Az ellenőrzés kukac előtt több pont esetén nem dob kivételt!");
        } catch (Exception e) {
            if (e.getMessage() != "Az email cím kukac előtt több pontot tartalmaz!") {
                fail("Kukac előtt több pont és az ellenőrzés rossz szövegű kivételt dob!");
            }
        }
    }

    @Test
    public void testEllenorzesTokeletesEmailCim() {
        System.out.println("testEllenorzesTokeletesEmailCim");
        try {
            EmailTar instance = new EmailTar("nagy.peti@vasvari.hu");
            instance.ellenorzes();
        } catch (Exception e) {
            fail("Az ellenőrző jó, az email címre kivételt dobott!");
        }
    }
}
