import gi

gi.require_version('Gtk', '3.0')
from gi.repository import Gtk as gtk
from datetime import datetime


class Main:
    def __init__(self):

        gladeFile = "project.glade"
        self.builder = gtk.Builder()
        self.builder.add_from_file(gladeFile)
        self.builder.connect_signals(self)

        window = self.builder.get_object("Main")
        window.connect("delete-event", gtk.main_quit)
        window.show()

    def getResult(self, widget):

        datenow = self.builder.get_object('datenow')
        cont = self.builder.get_object('cont')
        symp = self.builder.get_object('symp')
        test = self.builder.get_object('test')
        result = self.builder.get_object('result')
        ch1 = self.builder.get_object('ch1')
        datecont = None
        datesymp = None
        datetest = None
        datecurr = None
        intcub = 10
        intkwant = 10

        if date := datenow.get_text():
            try:
                datecurr = datetime.strptime(date, '%d.%m.%Y')
            except ValueError:
                result.set_text("Error: Write a date.")
        if date := cont.get_text():
            try:
                datecont = datetime.strptime(date, '%d.%m.%Y')
            except ValueError:
                result.set_text("Error: Write a date.")
        if date := symp.get_text():
            try:
                datesymp = datetime.strptime(date, '%d.%m.%Y')
            except ValueError:
                result.set_text("Error: Write a date.")
        if date := test.get_text():
            try:
                datetest = datetime.strptime(date, '%d.%m.%Y')
            except ValueError:
                result.set_text("Error: Write a date.")

        if datecurr:
            if datecont:
                if datecurr >= datecont:
                    prokerka3 = (datecurr - datecont)
                    if 0 <= prokerka3.days <= intcub:
                        result.set_text(
                            "You might be infected. Make a test after " + str(intcub - prokerka3.days) + " days.")
                        return
                    else:
                        result.set_text("You're probably not infected.")
                        return
                else:
                    result.set_text("Error: Date contact can't be greater than current date.")
                    return
            else:
                result.set_text("Error: There is no date contact.")
                # return

            if datesymp:
                if datecurr >= datesymp:
                    if datecont >= datesymp:
                        prokerka8 = (datecurr - datesymp)
                        if prokerka8.days > intcub:
                            result.set_text("You're probably not infected. Please, make")
                            return
                        elif 0 <= prokerka8.days <= intcub:
                            result.set_text("You might be infected. Please, make a test after " + str(intcub - prokerka8.days) + " days.")
                            #return
                        else:
                            result.set_text("You might be infected, make a test after " + str(intcub - prokerka8.days) + " days.")
                            #return
                    else:
                        result.set_text("Error: Symptoms date can't be larger than contact date")
                        return
                else:
                    result.set_text("Error: Date symptoms can't be larger than current date.")
                    return
            else:
                result.set_text("Error: There is no date symptoms.")
                # return
            if datetest:
                prokerka9 = (datecurr - datetest)
                if datetest <= datecurr:
                    if 0 <= prokerka9.days <= 10 and ch1.get_active():
                        result.set_text("You are infected. Stay home for " + str(intkwant - prokerka9.days) + " days.")
                        return
                    elif prokerka9.days >= 13 and ch1.get_active() or prokerka9.days >= 13 and not ch1.get_active():
                        result.set_text("You might be infected. Please, make a test.")
                        return
                    elif datetest == datecurr and datecont == datesymp and ch1.get_active():
                        result.set_text("You are infected, stay home for " + str(intkwant - prokerka9.days) + " days.")
                    elif datetest == datecurr and datecont == datesymp and not ch1.get_active():
                        result.set_text("You are not infected.")
                    else:
                        result.set_text("You are not infected.")
                        return
                else:
                    result.set_text("Error: Date test can't be larger than current date.")
                    return
            else:
                result.set_text("Error: There is no date test.")
                # return
        else:
            result.set_text("Error: There is no current date.")
            return


if __name__ == '__main__':
    main = Main()
    gtk.main()

