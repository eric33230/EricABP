import { EricABPTemplatePage } from './app.po';

describe('EricABP App', function() {
  let page: EricABPTemplatePage;

  beforeEach(() => {
    page = new EricABPTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
