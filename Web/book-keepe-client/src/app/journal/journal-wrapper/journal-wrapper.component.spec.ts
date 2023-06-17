import { ComponentFixture, TestBed } from '@angular/core/testing';

import { JournalWrapperComponent } from './journal-wrapper.component';

describe('JournalWrapperComponent', () => {
  let component: JournalWrapperComponent;
  let fixture: ComponentFixture<JournalWrapperComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [JournalWrapperComponent]
    });
    fixture = TestBed.createComponent(JournalWrapperComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
