def testNotification(self):
    self.count = 0 # 追加
    result = TestResult()
    result.addListener(self) # selfを引数に追加
    WasRun("testMethod").run(result)
    assert(1 == self.count)

def startTest(self):
    self.count = self.count + 1