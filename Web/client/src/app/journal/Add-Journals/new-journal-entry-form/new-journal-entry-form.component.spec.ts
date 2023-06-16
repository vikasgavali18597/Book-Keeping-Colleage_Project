import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NewJournalEntryFormComponent } from './new-journal-entry-form.component';

describe('NewJournalEntryFormComponent', () => {
  let component: NewJournalEntryFormComponent;
  let fixture: ComponentFixture<NewJournalEntryFormComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [NewJournalEntryFormComponent]
    });
    fixture = TestBed.createComponent(NewJournalEntryFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
