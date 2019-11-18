def testTemplateMethod(self):
    test = WasRun("testMethod")
    result = TestResult()
    test.run(result)
    assert("setUp testMethod tearDown" == test.log)

def setUp(self):
    self.log = "setUp "
def testMethod(self):
    self.log = self.log + "testMethod "
def tearDown(self):
    self.log = self.log + "tearDown"