package osszeadas;

public class OsszeadasJFrame extends javax.swing.JFrame {

    public OsszeadasJFrame() {
        initComponents();
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanelMain = new javax.swing.JPanel();
        jLabelOsszeadando1 = new javax.swing.JLabel();
        jLabelOsszeadando2 = new javax.swing.JLabel();
        jTextFieldOsszead1 = new javax.swing.JTextField();
        jTextFieldOsszead2 = new javax.swing.JTextField();
        jTextFieldOsszeg = new javax.swing.JTextField();
        jButtonOsszead = new javax.swing.JButton();
        jButtonTorles = new javax.swing.JButton();
        jButtonKilepes = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        jLabelOsszeadando1.setText("Első szám:");

        jLabelOsszeadando2.setText("Második szám:");

        jButtonOsszead.setText("Összeadás");
        jButtonOsszead.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                jButtonOsszeadMouseClicked(evt);
            }
        });

        jButtonTorles.setText("Törlés");
        jButtonTorles.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                jButtonTorlesMouseClicked(evt);
            }
        });

        jButtonKilepes.setText("Kilépés");

        javax.swing.GroupLayout jPanelMainLayout = new javax.swing.GroupLayout(jPanelMain);
        jPanelMain.setLayout(jPanelMainLayout);
        jPanelMainLayout.setHorizontalGroup(
            jPanelMainLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanelMainLayout.createSequentialGroup()
                .addContainerGap()
                .addGroup(jPanelMainLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jPanelMainLayout.createSequentialGroup()
                        .addGroup(jPanelMainLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jLabelOsszeadando2)
                            .addComponent(jLabelOsszeadando1))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(jPanelMainLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jTextFieldOsszeg)
                            .addComponent(jTextFieldOsszead1)
                            .addComponent(jTextFieldOsszead2)))
                    .addGroup(jPanelMainLayout.createSequentialGroup()
                        .addComponent(jButtonOsszead)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 57, Short.MAX_VALUE)
                        .addComponent(jButtonTorles, javax.swing.GroupLayout.PREFERRED_SIZE, 85, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(48, 48, 48)
                        .addComponent(jButtonKilepes, javax.swing.GroupLayout.PREFERRED_SIZE, 85, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addContainerGap())
        );
        jPanelMainLayout.setVerticalGroup(
            jPanelMainLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanelMainLayout.createSequentialGroup()
                .addContainerGap()
                .addGroup(jPanelMainLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabelOsszeadando1)
                    .addComponent(jTextFieldOsszead1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(jPanelMainLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabelOsszeadando2)
                    .addComponent(jTextFieldOsszead2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(26, 26, 26)
                .addComponent(jTextFieldOsszeg, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(28, 28, 28)
                .addGroup(jPanelMainLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jButtonOsszead)
                    .addComponent(jButtonTorles)
                    .addComponent(jButtonKilepes))
                .addContainerGap(124, Short.MAX_VALUE))
        );

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jPanelMain, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jPanelMain, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void jButtonTorlesMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_jButtonTorlesMouseClicked
        jTextFieldOsszead1.setText("");
        jTextFieldOsszead2.setText("");
        jTextFieldOsszeg.setText("");
    }//GEN-LAST:event_jButtonTorlesMouseClicked

    private void jButtonOsszeadMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_jButtonOsszeadMouseClicked
        String elsoSzam = jTextFieldOsszead1.getText();
        String masodikSzam = jTextFieldOsszead2.getText();

        double o1 = Double.parseDouble(elsoSzam);
        double o2 = Double.parseDouble(masodikSzam);

        double e = o1 + o2;

        jTextFieldOsszeg.setText(String.valueOf(e));
    }//GEN-LAST:event_jButtonOsszeadMouseClicked

    public static void main(String args[]) {
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(OsszeadasJFrame.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(OsszeadasJFrame.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(OsszeadasJFrame.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(OsszeadasJFrame.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }

        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new OsszeadasJFrame().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jButtonKilepes;
    private javax.swing.JButton jButtonOsszead;
    private javax.swing.JButton jButtonTorles;
    private javax.swing.JLabel jLabelOsszeadando1;
    private javax.swing.JLabel jLabelOsszeadando2;
    private javax.swing.JPanel jPanelMain;
    private javax.swing.JTextField jTextFieldOsszead1;
    private javax.swing.JTextField jTextFieldOsszead2;
    private javax.swing.JTextField jTextFieldOsszeg;
    // End of variables declaration//GEN-END:variables
}
