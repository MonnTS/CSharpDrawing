import javax.swing.*;
import javax.swing.border.BevelBorder;
import java.awt.*;

public class GridBagLayoutFrame extends JFrame {

    GridBagLayoutFrame()
    {
        JLabel jLabelLeft = new JLabel("Left");
        JLabel jLabelLeft1 = new JLabel("Lefty");
        JLabel jLabelRight = new JLabel("Right");
        JLabel jLabelRight1 = new JLabel("Righty");
        JLabel jLabelMenu1 = new JLabel("File");
        JLabel jLabelMenu2 = new JLabel("Edit");
        JLabel jLabelMenu3 = new JLabel("Exit");
        JLabel jlabelStatusBar = new JLabel("Status bar");
        jlabelStatusBar.setBorder(new BevelBorder(BevelBorder.LOWERED));

        JButton jButtonMenu = new JButton("Press F");

        JTextField jTextFieldCenter = new JTextField("Sample text");

        jTextFieldCenter.setHorizontalAlignment(SwingConstants.CENTER);
        jLabelLeft.setHorizontalAlignment(SwingConstants.CENTER);
        jLabelRight.setHorizontalAlignment(SwingConstants.CENTER);

        GridBagLayout gbl = new GridBagLayout();
        GridBagConstraints gcon = new GridBagConstraints();

        gcon.weightx = 1;
        gcon.weighty = 1;
        gcon.fill = GridBagConstraints.BOTH;

        gcon.gridx = 0;
        gcon.gridy = 1;
        gcon.gridwidth = 1;
        gcon.gridheight = 2;
        gbl.setConstraints(jLabelLeft, gcon);
        add(jLabelLeft);

        gcon.gridx = 1;
        gcon.gridy = 1;
        gcon.gridwidth = 1;
        gcon.gridheight = 2;
        gbl.setConstraints(jLabelLeft1, gcon);
        add(jLabelLeft1);

        gcon.gridx = 6;
        gcon.gridy = 1;
        gcon.gridwidth = 1;
        gcon.gridheight = 2;
        gbl.setConstraints(jLabelRight, gcon);
        add(jLabelRight);

        gcon.gridx = 7;
        gcon.gridy = 1;
        gcon.gridwidth = 1;
        gcon.gridheight = 2;
        gbl.setConstraints(jLabelRight1, gcon);
        add(jLabelRight1);

        gcon.gridx = 2;
        gcon.gridy = 0;
        gcon.gridwidth = 1;
        gcon.gridheight = 1;
        gbl.setConstraints(jLabelMenu1, gcon);
        add(jLabelMenu1);

        gcon.gridx = 3;
        gcon.gridy = 0;
        gcon.gridwidth = 1;
        gcon.gridheight = 1;
        gbl.setConstraints(jLabelMenu2, gcon);
        add(jLabelMenu2);

        gcon.gridx = 4;
        gcon.gridy = 0;
        gcon.gridwidth = 1;
        gcon.gridheight = 1;
        gbl.setConstraints(jLabelMenu3, gcon);
        add(jLabelMenu3);

        gcon.gridx = 5;
        gcon.gridy = 0;
        gcon.gridwidth = 1;
        gcon.gridheight = 1;
        gbl.setConstraints(jButtonMenu, gcon);
        add(jButtonMenu);

        gcon.gridx = 2;
        gcon.gridy = 1;
        gcon.gridwidth = 4;
        gcon.gridheight = 3;
        gbl.setConstraints(jTextFieldCenter, gcon);
        add(jTextFieldCenter);

        gcon.gridx = 2;
        gcon.gridy = 4;
        gcon.gridwidth = 4;
        gcon.gridheight = 1;
        gbl.setConstraints(jlabelStatusBar, gcon);
        add(jlabelStatusBar);

        this.setTitle("GridBagLayoutSample");
        this.setDefaultCloseOperation(EXIT_ON_CLOSE);
        this.setSize(460,200);
        this.setLocation(100,100);
        this.setLayout(gbl);
        this.setVisible(true);
    }
}
