import javax.swing.*;
import javax.swing.border.BevelBorder;
import java.awt.*;

public class BorderLayoutFrame extends JFrame {
    BorderLayoutFrame()
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

        JPanel p = new JPanel();
        JPanel p1 = new JPanel();
        JPanel p2 = new JPanel();
        JPanel p3 = new JPanel();
        JPanel p4 = new JPanel();

        p.add(jLabelMenu1);
        p.add(jLabelMenu2);
        p.add(jLabelMenu3);
        p.add(jButtonMenu);

        p1.add(jLabelLeft);
        p1.add(jLabelLeft1);

        p2.add(jLabelRight);
        p2.add(jLabelRight1);

        p3.add(jTextFieldCenter);

        p4.add(jlabelStatusBar);

        add(p, BorderLayout.NORTH);
        add(p1, BorderLayout.WEST);
        add(p2, BorderLayout.EAST);
        add(p3, BorderLayout.CENTER);
        add(p4, BorderLayout.SOUTH);

        this.setTitle("FlowLayoutFrameSample");
        this.setDefaultCloseOperation(EXIT_ON_CLOSE);
        this.setSize(460,200);
        this.setVisible(true);
        this.setLocation(100,100);
        this.setLayout(new BorderLayout());
    }
}
