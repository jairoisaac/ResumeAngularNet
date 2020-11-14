import { TestBed, async } from '@angular/core/testing';
import { RouterTestingModule } from '@angular/router/testing';
import { ResumeComponent } from './resume.component';

describe('ResumeComponent', () => {
  beforeEach(async(() => {
    TestBed.configureTestingModule({
      imports: [
        RouterTestingModule
      ],
      declarations: [
        ResumeComponent
      ],
    }).compileComponents();
  }));

  it('should create the app', () => {
    const fixture = TestBed.createComponent(ResumeComponent);
    const app = fixture.componentInstance;
    expect(app).toBeTruthy();
  });

  it(`should have as name 'Jairo Millan'`, () => {
    const fixture = TestBed.createComponent(ResumeComponent);
    const app = fixture.componentInstance;
    expect(app.Nombre).toEqual('Jairo Millan');
  });

  it('should render title', () => {
    const fixture = TestBed.createComponent(ResumeComponent);
    fixture.detectChanges();
    const compiled = fixture.nativeElement;
    expect(compiled.querySelector('.content span').textContent).toContain('myResune app is running!');
  });
});
