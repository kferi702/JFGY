package emailtarprojekt;

import java.util.logging.Level;
import java.util.logging.Logger;
import org.junit.After;
import org.junit.AfterClass;
import org.junit.Before;
import org.junit.BeforeClass;
import org.junit.Test;
import static org.junit.Assert.*;

/**
 * Unit teszt osztály
 *
 * @author Bence
 */
public class EmailTarTest {

    /**
     * Konstruktor
     */
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
                fail("Rossz szövegű kivételt dob!");
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
                fail("Rossz szövegű kivételt dob!");
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
                fail("Rossz szövegű kivételt dob!");
            }
        }
    }

    @Test
    public void testEllenorzesNagybetuEsTobbPontKukacElott() {
        System.out.println("testEllenorzesNagybetuKisbetuEsTobbPontKukacElott");
        try {
            EmailTar instance = new EmailTar("peti.p.p@vaSvari.hu");
            instance.ellenorzes();
            fail("Az ellenőrzés kukac előtt több pont esetén nem dob kivételt!");
        } catch (Exception e) {
            if (e.getMessage() != "Az email cím kukac előtt több pontot tartalmaz!") {
                fail("Rossz szövegű kivételt dob!");
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
