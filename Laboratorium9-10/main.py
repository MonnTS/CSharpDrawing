import wx
import json
from datetime import datetime, timedelta


class MainWindow(wx.Frame):

    def __init__(self, parent, id, title):
        wx.Frame.__init__(self, parent, id, title=title, size=(1000, 500))

        topPanel = wx.Panel(self)

        panel1 = wx.Panel(topPanel, -1, pos=(0, 0), size=(300, 300))

        self.source_list = wx.ListView(panel1, size=(300, 300), style=wx.LC_REPORT | wx.BORDER_SIMPLE)
        self.source_list.InsertColumn(0, "Title", width=300)
        self.Bind(wx.EVT_LIST_ITEM_SELECTED, self.onSelection, self.source_list)

        self.l1 = wx.StaticText(panel1, label="Title:", pos=(310, 10))
        self.l3 = wx.StaticText(panel1, label="Due:", pos=(310, 30))
        self.l4 = wx.StaticText(panel1, label="Text:", pos=(650, 10))

        self.t1 = wx.TextCtrl(panel1, pos=(390, 5))
        self.t2 = wx.TextCtrl(panel1, pos=(390, 30))
        self.t3 = wx.TextCtrl(panel1, style=wx.TE_MULTILINE, size=(250, 250), pos=(550, 30))

        self.b1 = wx.Button(panel1, label="Delete", pos=(850, 255))
        self.Bind(wx.EVT_BUTTON, self.removeOn, self.b1)
        self.b2 = wx.Button(panel1, label="Update", pos=(850, 230))
        self.Bind(wx.EVT_BUTTON, self.updateOn, self.b2)
        self.b3 = wx.Button(panel1, label="Add", pos=(850, 205))
        self.Bind(wx.EVT_BUTTON, self.addOn, self.b3)

        self.r1 = wx.RadioButton(panel1, label="This week", pos=(310, 80))
        self.Bind(wx.EVT_RADIOBUTTON, self.wk, self.r1)
        self.r2 = wx.RadioButton(panel1, label="This month", pos=(310, 100))
        self.Bind(wx.EVT_RADIOBUTTON, self.mt, self.r2)
        self.r3 = wx.RadioButton(panel1, label="This quarter", pos=(310, 120))
        self.Bind(wx.EVT_RADIOBUTTON, self.qt, self.r3)
        self.r4 = wx.RadioButton(panel1, label="This half of year", pos=(310, 140))
        self.Bind(wx.EVT_RADIOBUTTON, self.hy, self.r4)
        self.r5 = wx.RadioButton(panel1, label="All", pos=(310, 160))
        self.Bind(wx.EVT_RADIOBUTTON, self.all, self.r5)
        self.r6 = wx.RadioButton(panel1, label="Out of date", pos=(310, 180))
        self.Bind(wx.EVT_RADIOBUTTON, self.outof, self.r6)

        sizer = wx.BoxSizer(wx.VERTICAL)
        sizer.Add(panel1, 0, wx.EXPAND | wx.ALL, border=10)

        topPanel.SetSizer(sizer)

        self.getSource()
        self.gen()

    def wk(self, event):
        now = datetime.now()
        self.getSource((now - timedelta(days=now.weekday()), now + timedelta(days=6 - now.weekday())))

    def mt(self, event):
        now = datetime.now()
        self.getSource((datetime(now.year, now.month, 1), datetime(now.year, now.month, 31)))

    def qt(self, event):
        now = datetime.now()
        quarter_num = ((now.month - 1) // 3) + 1

        if quarter_num == 1:
            self.getSource((datetime(year=now.year, month=1, day=1), datetime(year=now.year, month=3, day=31)))
        elif quarter_num == 2:
            self.getSource((datetime(year=now.year, month=4, day=1), datetime(year=now.year, month=6, day=30)))
        elif quarter_num == 3:
            self.getSource((datetime(year=now.year, month=7, day=1), datetime(year=now.year, month=9, day=30)))
        elif quarter_num == 4:
            self.getSource((datetime(year=now.year, month=10, day=1), datetime(year=now.year, month=12, day=31)))

    def hy(self, event):
        now = datetime.now()
        self.getSource((datetime(now.year, 1, 1), datetime(now.year, 12, 31)))

    def all(self, event):
        self.getSource()

    def outof(self, event):
        self.getSource((datetime(year=1, month=1, day=1), datetime.now()))

    def addOn(self, event):
        dit = dict()
        nr = self.t1.GetValue()
        nr1 = self.t2.GetValue()
        nr2 = self.t3.GetValue()

        dit[nr] = {
            "Due": nr1,
            "Text": nr2
        }

        if nr == "" or nr1 == "" or nr2 == "":
            wx.MessageBox('Error: Fill all data', 'Warning', wx.OK | wx.ICON_WARNING)
            return

        else:
            if not self.setProkerka():
                return
            if nr not in self.readData():
                self.writeData(dit)
                self.source_list.Append([nr])
                self.t1.Clear()
                self.t2.Clear()
                self.t3.Clear()
            else:
                wx.MessageBox('Error: record already exists!', 'Warning', wx.OK | wx.ICON_WARNING)

    def removeOn(self, event):
        index = self.source_list.GetFirstSelected()
        if index == -1:
            wx.MessageBox('Error: Select an item', 'Warning', wx.OK | wx.ICON_WARNING)
            return

        title = self.source_list.GetItem(index).GetText()

        n = self.readData()
        n.pop(title)
        self.overrideData(n)
        self.source_list.DeleteItem(index)

    def onSelection(self, event):
        index = self.source_list.GetFirstSelected()
        title = self.source_list.GetItem(index).GetText()
        journal = self.readData()
        record = journal[title]

        self.t1.Clear()
        self.t2.Clear()
        self.t3.Clear()

        self.t1.write(title)
        self.t2.write(record["Due"])
        self.t3.write(record["Text"])

    def updateOn(self, event):
        dit = dict()
        nr = self.t1.GetValue()
        nr1 = self.t2.GetValue()
        nr2 = self.t3.GetValue()

        dit[nr] = {
            "Due": nr1,
            "Text": nr2
        }

        if nr == "" or nr1 == "" or nr2 == "":
            wx.MessageBox('Error: Fill all data', 'Warning', wx.OK | wx.ICON_WARNING)
            return
        else:
            if not self.setProkerka():
                return

            self.writeData(dit)
            self.getSource()

            self.t1.Clear()
            self.t2.Clear()
            self.t3.Clear()

    def gen(self):
        dit = dict()
        now = datetime.now()
        nr1 = datetime.strftime(now, '%d.%m.%Y')
        nr = "Test" + nr1
        nr2 = "Prok"

        if now.day == 1:
            dit[nr] = {
                "Due": nr1,
                "Text": nr2
            }
            self.writeData(dit)
            self.source_list.Append([nr])

    def notification(self):
        tl = list()
        for title, values in self.readData().items():
            nr = values["Due"]
            nr = datetime.strptime(nr, '%d.%m.%Y')

            if nr < datetime.now():
                tl.append(title)

        if len(tl) <= 1:
            wx.MessageBox('Your document: ' + ','.join(tl) + ' is out of date!', 'Warning', wx.OK | wx.ICON_WARNING)
        elif len(tl) > 1:
            wx.MessageBox('Your documents: ' + ','.join(tl) + ' are out of date!', 'Warning', wx.OK | wx.ICON_WARNING)

    def readData(self) -> dict:
        return json.load(open('prokerka.json'))

    def writeData(self, record: dict):
        e = self.readData()
        e |= record     # Совмещает два словаря
        self.overrideData(e)

    def overrideData(self, journal: dict):
        json.dump(journal, open('prokerka.json', 'w'), indent=4)

    def setProkerka(self):
        if date := self.t2.GetValue():
            try:
                self.v2 = datetime.strptime(date, '%d.%m.%Y')
                return True
            except ValueError:
                wx.MessageBox('Error: Write a date.', 'Warning', wx.OK | wx.ICON_WARNING)
        return False

    def getSource(self, date_filter: (datetime, datetime) = None):
        if not self.source_list.IsEmpty():
            self.source_list.DeleteAllItems()

        for title, values in self.readData().items():
            if date_filter:
                date = datetime.strptime(values["Due"], '%d.%m.%Y')
                if not date_filter[0] <= date <= date_filter[1]:
                    continue
            self.source_list.Append([title])


if __name__ == "__main__":
    app = wx.App()
    frame = MainWindow(None, 0, "Documents")
    frame.Show()
    frame.notification()
    app.MainLoop()
