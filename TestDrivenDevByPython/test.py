def testSuite(self):
    suite = TestSuite()
    suite.add(WasRun("testMethod"))
    suite.run(self.result)
    assert("1 run, 0 failed" == self.result.summary())

class TestSuite:
    def __init__(self):
        self.tests = []
    def add(self, test):
        self.test = test
        self.tests.append(test)
    def run(self, result):
        for test in self.tests:
            test.run(result)